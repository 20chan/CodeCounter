using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodeCounter
{
    public class TextAttribute
    {
        private static List<TextAttribute> attributes = new List<TextAttribute>();
        TextAttributeType type;
        string format;

        private TextAttribute(TextAttributeType t, string f)
        {
            this.type = t;
            this.format = f;
        }

        public bool isMatch(string path)
        {
            switch(type)
            {
                case TextAttributeType.INCLUDE:
                    if (path.Contains(format))
                        return true;
                    else return false;
                case TextAttributeType.EXCLUDE:
                    if (path.Contains(format))
                        return false;
                    else return true;
                case TextAttributeType.ENDSWITH:
                    if (path.EndsWith(format))
                        return true;
                    else return false;
                case TextAttributeType.NOTENDSWITH:
                    if (path.EndsWith(format))
                        return false;
                    else return true;
                case TextAttributeType.STARTSWITH:
                    if (path.StartsWith(format))
                        return true;
                    else return false;
                case TextAttributeType.NOTSTARTSWITH:
                    if (path.StartsWith(format))
                        return false;
                    else return true;

                default:
                    throw new Exception("Unexpected text attribute type!!");
            }
        }
        
        public static bool FromFormat(string format)
        {
            TextAttribute result = new TextAttribute(TextAttributeType.NONE, "");
            if (format.StartsWith("?/"))
            {
                if (!isCorrectFileName(format.Substring(2)))
                {
                    return false;
                }

                result = new TextAttribute(TextAttributeType.NOTENDSWITH, format.Substring(2));
            }
            else if (format.StartsWith("/"))
            {
                if (!isCorrectFileName(format.Substring(1)))
                {
                    return false;
                }

                result = new TextAttribute(TextAttributeType.ENDSWITH, format.Substring(1));
            }
            else if (format.StartsWith("?\\"))
            {
                if (!isCorrectFileName(format.Substring(2)))
                {
                    return false;
                }

                result = new TextAttribute(TextAttributeType.NOTSTARTSWITH, format.Substring(2));
            }
            else if (format.StartsWith("\\"))
            {
                if (!isCorrectFileName(format.Substring(1)))
                {
                    return false;
                }

                result = new TextAttribute(TextAttributeType.STARTSWITH, format.Substring(1));
            }
            else if (format.StartsWith(":"))
            {
                if (!isCorrectFileName(format.Substring(1)))
                {
                    return false;
                }

                result = new TextAttribute(TextAttributeType.INCLUDE, format.Substring(1));
            }
            else if (format.StartsWith("?:"))
            {
                if (!isCorrectFileName(format.Substring(2)))
                {
                    return false;
                }

                result = new TextAttribute(TextAttributeType.EXCLUDE, format.Substring(2));
            }
            else
            {
                return false;
            }

            attributes.Add(result);
            return true;
        }

        public static bool isMatchingAttributes(string path)
        {
            foreach(TextAttribute t in attributes)
            {
                if (!t.isMatch(path))
                    return false;
            }

            return true;
        }

        private static bool isCorrectFileName(string name)
        {
            if(name.Contains("\\") || name.Contains("/") || name.Contains(":") || name.Contains("*") || name.Contains("?") || name.Contains("\"") || name.Contains("<") || name.Contains(">") || name.Contains("|"))
            {
                return false;
            }

            return true;
        }

        public static void Clear()
        {
            attributes = new List<TextAttribute>();
        }
    }
}
