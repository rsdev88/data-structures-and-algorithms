using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.ExampleQuestions
{
    public class ExampleQuestions_QueuesAndStacks
    {

        //Build a queue using only stacks.
        // It must have enqueue, dequeue and peek functions.

        public class StackBasedQueue
        {
            private Stack<int> normalStack;
            private Stack<int> reversedStack;

            public StackBasedQueue()
            {
                this.normalStack = new Stack<int>();
                this.reversedStack = new Stack<int>();
            }

            public void Enqueue(int item)
            {
                //Take the existing normal stack and pop each of its items, pushing them onto the reversed stack.
                var originalLength = this.normalStack.Count;
                for (int i = 0; i <= originalLength - 1; i++)
                {
                    this.reversedStack.Push(this.normalStack.Pop());
                }

                //Then push the new item to the top of the reversed stack.
                this.reversedStack.Push(item);
            }

            public int Dequeue()
            {
                //Take the reversed stack and pop each of its items, pushing them onto the normal stack.
                var originalLength = this.reversedStack.Count;
                for (int i = 0; i <= originalLength - 1; i++)
                {
                    this.normalStack.Push(this.reversedStack.Pop());
                }

                //Then pop from the top of the normal stack.
                return this.normalStack.Pop();
            }

            public int Peek()
            {
                // If there's anything in the reversed stack, return the bottom item
                if (this.reversedStack.Count > 0)
                {
                    var array = this.reversedStack.ToArray();
                    return array[array.Length - 1];
                }

                //Otherwise, return the top of the normal stack
                return this.normalStack.Pop();
            }

            public bool IsEmpty()
            {
                return this.normalStack.Count == 0 && this.reversedStack.Count == 0;
            }

        }
    }
}

