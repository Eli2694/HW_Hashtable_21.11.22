using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hashtable_21._11._22
{
    internal class iceCream
    {
        // Variable

        private int id;
        public int Id
        {
            get { return id; }
        }

        private int icecreamBalls;

        public int IcecreamBalls
        {
            get { return icecreamBalls; }
            
        }


        // Constructor
        public iceCream(int id,int icecreamBalls)
        {
            this.id = id;
            this.icecreamBalls = icecreamBalls;
        }


    }
}
