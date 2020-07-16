using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Algorithms
{
    public class Recursion
    {
        
        private int Counter { get; set; }

        public Recursion()
        {
            this.Counter = 0;
        }

        //Basic recursion
        //Will keep calling itself until counter > 3.
        //Each subsequent call will be added to the call stack. Without a base case, recusion can result in a stack overflow.
        //Note the "return" keyword before the call to itself - this ensures the "Done!" value bubbles back up to, and is returned by, the first call to Inception. 
        public string Inception()
        {
            if (this.Counter > 3)    //Base case
            {
                return "Done!";
            }

            this.Counter++;
            return Inception();      //Recursion case
        }



    }
}
