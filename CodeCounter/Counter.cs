using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodeCounter
{
    public class Counter
    {
        private string directory;
        private bool isCheckSubFoldder;

        List<string> searchedFiles;

        public Counter(string direct, bool subFolder)
        {
            this.directory = direct;
            this.isCheckSubFoldder = subFolder;
            searchedFiles = files(directory);
        }

        public List<FileLine> Count()
        {
            List<FileLine> lines = new List<FileLine>();
            foreach(string s in searchedFiles)
            {
                lines.Add(new FileLine(s, File.ReadLines(s).Count()));
            }
            return lines;
        }

        private List<string> files(string path)
        {
            List<string> currentFiles = new List<string>();

            foreach(string s in Directory.GetFiles(path))
            {
                if(isMatchingFile(s))
                {
                    currentFiles.Add(s);
                }
            }

            if (isCheckSubFoldder)
            {
                List<string> subDirects = Directory.GetDirectories(path).ToList();
                foreach (string s in subDirects)
                {
                    currentFiles.AddRange(files(s));
                }
            }

            return currentFiles;
        }

        private bool isMatchingFile(string filepath)
        {
            return TextAttribute.isMatchingAttributes(Path.GetFileName(filepath));
        }
    }
}
