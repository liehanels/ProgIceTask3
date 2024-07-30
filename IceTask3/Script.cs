using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask3
{
    class Script
    {
        private int index;
        private string line;

        public Script() { }
        public Script(int index, string line)
        {
            this.index = index;
            this.line = line;
        }
        public int Index() {  return index; }
        public string Line() { return line; }
    }
}
