using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;
using System.Text;

namespace DataStructuresAndAlgorithms.DataStructures
{
    // Building a dynamic array from scratch to show how it works behind the scenes
    // I've used a dictionary for the underlying data for simplicity.
    public class DynamicArray<T>
    {
        public int Length { get; set; }

        public IDictionary<int, T> Data;

        public DynamicArray()
        {
            this.Length = 0;
            this.Data = new Dictionary<int, T>();
        }

        public T GetItem(int index)
        {
            if (index >= this.Length)
            {
                return default(T);
            }
            return this.Data[index];
        }

        //O(1)
        public void Push(T item)
        {
            this.Data.Add(this.Length, item);
            this.Length++;
        }

        //O(1)
        public void Pop()
        {
            this.Data.Remove((Length - 1));
            this.Length--;
        }

        //O(n)
        public void Delete(int index)
        {
            //Shift the items in the array to the left
            for (int i = index; i < this.Length - 1; i++)
            {
                this.Data[i] = this.Data[i + 1];
            }

            //Then delete the last item
            this.Pop();
        }

        //O(n)
        public void Insert(int index, T item)
        {
            //Expand the array by one
            this.Push(default(T));

            //Shift the items in the array to the right starting from the end
            //so items aren't overwritten too early.
            for (int i = this.Length - 1; i > index; i--)
            {
                this.Data[i] = this.Data[i - 1];
            }

            //Add the new item into the array at the specified index.
            this.Data[index] = item;
        }
    }
}
