using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class EvenNumbers : NaturalNumbers
    {
        public EvenNumbers()
        {
            first = 2;
            increment = 2;
        }

        //// Override changes a previously defined method
        //public override int GetNext(int x)
        //{
        //    // return x + 2;
        //    // call parent method then add 1 to returned value
        //    return base.GetNext(x) + 1;
        //}


    }
}
