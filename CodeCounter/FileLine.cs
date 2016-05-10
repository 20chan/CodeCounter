using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCounter
{
    public struct FileLine
    {
        public FileLine(string path, int line)
        {
            this.Path = path;
            this.Line = line;
        }

        public string Path;
        public int Line;
    }
}
