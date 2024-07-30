using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask3
{
    class LinkedList : IEnumerable<Node>
    {
        private Node head;
        private Node tail;
        public Node First { get { return head; } }
        public Node Last { get { return tail; } }
        public int Length { get; private set; }
        public IEnumerator<Node> GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void Add(Script line)
        {
            Node newNode = new Node(line);
            if (tail == null)
            {
                head = newNode;
            }
            else
            {
                newNode.Previous = tail;
                tail.Next = newNode;
            }
            tail = newNode;
            Length++;
        }
        public Node Find(Script line)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data.Index == line.Index)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }
    }
}
