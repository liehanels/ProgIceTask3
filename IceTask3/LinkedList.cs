﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;

namespace IceTask3
{
    class LinkedList : IEnumerable<Node>
    {
        private Node Head;
        private Node Tail;
        public Node First { get { return Head; } }
        public Node Last { get { return Tail; } }
        public int Length { get; private set; }
        public IEnumerator<Node> GetEnumerator()
        {
            Node current = Head;
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
            if (Tail == null)
            {
                Head = newNode;
            }
            else
            {
                newNode.Previous = Tail;
                Tail.Next = newNode;
            }
            Tail = newNode;
            Length++;
        }
        public string Find(int line)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Data.Index() == line)
                {
                    return current.Data.Line();
                }
                current = current.Next;
            }
            return null;
        }
        public void Swap(Node node1, Node node2)
        {
            if(node1.Next != node2)
            {
                throw new Exception("Nodes not next to each other");
            }
            /*if(node1.Previous == null)
            {
                throw new Exception("No item before: " + node1.Data.Index());
            }*/
            if(node1.Previous != null && node2.Next != null)
            {
                //if (node2.Next != null) 
                node2.Next.Previous = node1;
                node1.Previous.Next = node2;
                node2.Previous = node1.Previous;
                node1.Next = node2.Next;
                node2.Next = node1;
                node1.Previous = node2;
            }
            if (node1.Previous == null)
            {
                node2.Previous = null;
                node2.Next.Previous = node1;
                node1.Next = node2.Next;
                node2.Next = node1;
                node1.Previous = node2;
                Head = node2;
            }
            if (node2.Next == null)
            {
                node1.Next = null;
                node1.Previous.Next = node2;
                node2.Next = node1;
                node2.Previous = node1.Previous;
                node1.Previous = node2;
                Tail = node1;
            }
        }
        public void Sort()
        {
            //current = current.Next;
            //current = current.Next;
            //Swap(current, current.Next);
            //int counter = 0;
            bool iterate = true;
            while (iterate)
            {
                Node current = Head;
                iterate = false;
                while (true)
                {
                    //if (current.Next != null && current.Next.Data.Index() != 8) { continue; }
                    if (current == null || current.Next == null) { break; }
                    if (current.Next != null && current.Data.Index() > current.Next.Data.Index())
                    {
                        Swap(current, current.Next);
                        //current = current.Previous;
                        iterate = true;
                    }
                    current = current.Next;
                    //counter++;
                    //if(counter == 2) { break; }
                    /*Node next = current.Next;
                    {
                        while (next.Next != null)
                        {
                            Node temp = next;
                            next = current;
                            current = temp;
                            next = next.Next;
                        }
                    }
                    current = current.Next;*/
                }
            }
        }
    }
}
