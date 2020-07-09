using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.DataStructures
{
    //A queue built using a linked list
    //First in, first out
    public class Queue
    {
        public LinkedListNode Head { get; set; }
        public LinkedListNode Tail { get; set; }
        public int Length { get; set; }
        public bool IsEmpty { get { return this.Length == 0; } }

        public Queue(int item)
        {
            this.Head = new LinkedListNode(item);
            this.Tail = this.Head;
            this.Length = 1;
        }

        //Insert at the tail - O(1)
        public void Enqueue(int item)
        {
            var newNode = new LinkedListNode(item);
            this.Tail.Next = newNode;
            this.Tail = newNode;
            this.Length++;
        }

        //Remove from the head - O(1)
        // My implementation of Dequeue returns the dequeued item rather than just deleting it from memory;
        public int Dequeue()
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
