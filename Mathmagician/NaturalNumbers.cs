using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class NaturalNumbers
    {
        // Anything outside of the NaturalNumbers class can't access first
        // Known as a data member (don't put literals in methods)
        protected int first;
        protected int increment;
        // protected means children of class will have access

        // Constructor method explicitly declared, overriding default
        // Runs everytime we make a new instance
        public NaturalNumbers()
        {
            first = 1;
            increment = 1;
        }

        // mapping expression works for any number after 1
        // virtual allows us to override
        public virtual int GetNext(int x)
        {
            return x + increment;
        }

        // Public Method that returns int, inside NaturalNumbers class
        // Base case
        public int GetFirst()
        {
            return first;
        }

        public int[] GetSequence()
        {
            return GetSequence(10);
        }

        // overloaded methods, an ability of object oriented programming
        public int[] GetSequence(int length)
        {
            List<int> output = new List<int>();
            output.Add(GetFirst());
            while (output.Count < length)
            {
                output.Add(GetNext(output.Last()));
            }
            return output.ToArray();
        }

        public string ToString(int[] array)
        {
            string output = String.Join(" ", array);
            return output;
        }
    }
}