using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask3
{
    class Node
    {
        private Script line;
        private Node next;
        private Node previous;
        public Script Data { get { return line; } set { line = value; } }
        public Node Next { get { return next; } set { next = value; } }
        public Node Previous { get { return previous; } set { previous = value; } }
        public Node(Script line) { this.line = line; }
    }
}
