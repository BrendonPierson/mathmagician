using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class FibonacciNumbers : NaturalNumbers
    {
        public FibonacciNumbers()
        {
            first = 1;
            increment = 2;
        }

        public int GetNext(int x, int y)
        {
            // return x + 2;
            // call parent method then add 1 to returned value
            return x + y;
        }

        new public int[] GetSequence(int length)
        {
            List<int> output = new List<int>();
            output.Add(GetFirst());
            if (output.Count < length)
            {
            output.Add(GetFirst());
            }
            while (output.Count < length)
            {
                output.Add(GetNext(output.Last(), output[output.Count - 2]));
                
            }
            return output.ToArray();
        }
    }
}
