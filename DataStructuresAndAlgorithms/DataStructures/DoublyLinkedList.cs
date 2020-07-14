using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.DataStructures
{
    // This is very similar to a singly-linked list with one enhancement: each node also stores
    // a pointer to the previous node (in addition to the next normal), allowing backwards
    // traversal of the list. This is quicker when looking up/inserting/deleting items in the
    // second half of the list.

    public class DoublyLinkedListNode
    {
        public DoublyLinkedListNode(int value, DoublyLinkedListNode next = null, DoublyLinkedListNode previous = null)
        {
            this.Value = value;
            this.Next = next;
            this.Previous = null;
        }

        public int Value { get; set; }
        public DoublyLinkedListNode Next { get; set; }
        public DoublyLinkedListNode Previous { get; set; }
    }

    // Building a doubly linked list to show how it works behind the scenes.
    public class DoublyLinkedList
    {
        public DoublyLinkedListNode Head { get; set; }
        public DoublyLinkedListNode Tail { get; set; }
        public int Length { get; set; }

        public DoublyLinkedList(int initialValue)
        {
            this.Head = new DoublyLinkedListNode(initialValue, null);
            this.Tail = this.Head;

            this.Length = 1;
        }

        //O(1)
        public void Prepend(int value)
        {
            var newNode = new DoublyLinkedListNode(value, this.Head);
            this.Head.Previous = newNode;
            this.Head = newNode;
            this.Length++;
        }

        //O(1)
        public void Append(int value)
        {

            var newNode = new DoublyLinkedListNode(value, null);
            newNode.Previous = this.Tail;
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
                currentSecondNode.Previous = null;
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

        //O(1) as, unlike a singly linked list, you do not have to traverse from the head.
        public void DeleteFromEnd()
        {
            if (this.Length > 1)
            {
                var currentSecondToLastNode = this.Tail.Previous;
                currentSecondToLastNode.Next = null;
                this.Tail = currentSecondToLastNode;
                this.Length--;
            }
            else
            {
                this.Tail = null;
                this.Head = null;
                this.Length--;
            }
        }

        // O(n) as you have to traverse to the index at which the new value is being inserted.
        // Faster than a singly-linked list though when adding a item into the second half of the list.
        public void Insert(int index, int value)
        {
            if (index == 0)
            {
                this.Prepend(value);
            }

            //Don't do anything if the index is invalid.
            if (index <= this.Length)
            {
                var newNode = new DoublyLinkedListNode(value);

                //Traverse from the start
                if (index <= this.Length /2)
                {
                    var currentNode = this.Head;
                    var currentIndex = 1;

                    while (currentIndex <= index)
                    {
                        if (currentIndex == index - 1)
                        {
                            newNode.Next = currentNode.Next;
                            newNode.Previous = currentNode;
                            currentNode.Next.Previous = newNode;
                            currentNode.Next = newNode;
                            Length++;
                            break;
                        }

                        currentNode = currentNode.Next;
                        currentIndex++;
                    }
                }
                //Traverse from the end
                else
                {
                    var currentNode = this.Tail;
                    var currentIndex = this.Length + 1;

                    while (currentIndex > index)
                    {
                        if (currentIndex == index + 1)
                        {
                            newNode.Previous = currentNode.Previous;
                            newNode.Next = currentNode;
                            currentNode.Previous.Next = newNode;
                            currentNode.Previous = newNode;
                            Length++;
                            break;
                        }
                    }

                    currentNode = currentNode.Previous;
                    currentIndex--;
                }
            }
        }

        // O(n) as you have to traverse to the index at which the value is being deleted.
        // Faster than a singly-linked list though when adding a item into the second half of the list.
        public void Delete(int index)
        {
            if (index == 0)
            {
                this.DeleteFromStart();
            }

            //Don't do anything if the index is invalid.
            if (index <= this.Length)
            {
                if (index <= this.Length / 2)
                {
                    var currentNode = this.Head;
                    var currentIndex = 1;

                    while (currentIndex < index)
                    {
                        if (currentIndex == index - 1)
                        {
                            currentNode.Next = currentNode.Next.Next;
                            currentNode.Next.Previous = currentNode;
                            Length--;
                            break;
                        }

                        currentNode = currentNode.Next;
                        currentIndex++;
                    }
                }
                else
                {
                    var currentNode = this.Tail;
                    var currentIndex = this.Length;

                    while (currentIndex >= index)
                    {
                        if (currentIndex == index + 1)
                        {
                            currentNode.Previous = currentNode.Previous.Previous;
                            currentNode.Previous.Next = currentNode;
                            Length--;
                            break;
                        }

                        currentNode = currentNode.Previous;
                        currentIndex--;
                    }
                }

            }
        }
    }
    
}
