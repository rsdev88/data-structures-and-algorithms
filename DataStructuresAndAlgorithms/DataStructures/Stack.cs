using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.DataStructures
{
    // A stack built using a linked list
    // LIFO
    public class Stack
    {
        public LinkedListNode Head { get; set; }
        public int Length { get; set; }
        public bool IsEmpty { get { return this.Length == 0; } }

        public Stack(int item)
        {
            this.Head = new LinkedListNode(item);
            this.Length = 1;
        }

        //O(1)
        public void Push(int item)
        {
            var newNode = new LinkedListNode(item);
            newNode.Next = this.Head;
            this.Head = newNode;
            this.Length++;
        }

        //O(1)
        // My implementation of Pop returns the popped item rather than just deleting it from memory;
        public int Pop()
        {
            var oldHead = this.Head;
            this.Head = this.Head.Next;
            this.Length--;

            return oldHead.Value;
        }

        //O(1)
        public int Peek()
        {
            return this.Head.Value;
        }
    }
}
