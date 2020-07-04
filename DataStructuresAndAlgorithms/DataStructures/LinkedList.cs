using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace DataStructuresAndAlgorithms.DataStructures
{
    public class LinkedListNode
    {
        public LinkedListNode(int value, LinkedListNode next = null)
        {
            this.Value = value;
            this.Next = next;
        }

        public int Value { get; set; }
        public LinkedListNode Next {get; set;}
    }

    // Building a linked list to show how it works behind the scenes.
    public class LinkedList
    {
        public LinkedListNode Head { get; set; }
        public LinkedListNode Tail { get; set; }
        public int Length { get; set; }

        public LinkedList(int initialValue)
        {
            this.Head = new LinkedListNode(initialValue, null);
            this.Tail = this.Head;

            this.Length = 1;
        }

        //O(1)
        public void Prepend(int value)
        {
            var newNode = new LinkedListNode(value, this.Head);

            this.Head = newNode;
            this.Length++;
        }

        //O(1)
        public void Append(int value)
        {

            var newNode = new LinkedListNode(value);

            this.Tail.Next = newNode;
            this.Tail = newNode;
            this.Length++;
        }

        //O(1)
        public void DeleteFromStart()
        {
            if (this.Length > 1)
            {
                var currentSecondNode = this.Head.Next;
                this.Head = currentSecondNode;
                this.Length--;
            }
            else
            {
                this.Tail = null;
                this.Head = null;
                this.Length--;
            }
        }

        //O(n) as you have to traverse to the one before the last node.
        public void DeleteFromEnd()
        {
            if (this.Length > 1)
            {
                var currentNode = this.Head;
                var currentIndex = 1;

                while (currentIndex < this.Length)
                {
                    if (currentIndex == this.Length - 1)
                    {
                        currentNode.Next = null;
                        this.Tail = currentNode;
                        this.Length--;
                        break;
                    }

                    currentNode = currentNode.Next;
                    currentIndex++;
                }
            }
            else
            {
                this.Tail = null;
                this.Head = null;
                this.Length--;
            }
        }

        // O(n) as you have to traverse to the index at which the new value is being inserted.
        public void Insert(int index, int value)
        {
            if (index == 0)
            {
                this.Prepend(value);
            }

            //Don't do anything if the index is invalid.
            if (index <= this.Length)
            {
                var newNode = new LinkedListNode(value);

                var currentNode = this.Head;
                var currentIndex = 1;

                while (currentIndex <= index)
                {
                    if (currentIndex == index - 1)
                    {
                        newNode.Next = currentNode.Next;
                        currentNode.Next = newNode;
                        Length++;
                        break;
                    }

                    currentNode = currentNode.Next;
                    currentIndex++;
                }
            }
        }

        // O(n) as you have to traverse to the index at which the value is being deleted.
        public void Delete(int index)
        {
            if(index == 0)
            {
                this.DeleteFromStart();
            }

            //Don't do anything if the index is invalid.
            if (index <= this.Length)
            {
                var currentNode = this.Head;
                var currentIndex = 1;

                while (currentIndex < index)
                {
                    if (currentIndex == index - 1)
                    {
                        currentNode.Next = currentNode.Next.Next;
                        Length--;
                    }

                    currentNode = currentNode.Next;
                    currentIndex++;
                }
            }
        }

    }
}
