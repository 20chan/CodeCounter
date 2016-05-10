using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCounter
{
    public enum TextAttributeType
    {
        NONE,

        INCLUDE,
        EXCLUDE,

        STARTSWITH,
        NOTSTARTSWITH,

        ENDSWITH,
        NOTENDSWITH
    }
}
