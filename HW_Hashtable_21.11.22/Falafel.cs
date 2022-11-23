using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hashtable_21._11._22
{
    internal class Falafel
    {
        private int id;
        public int Id
        {
            get { return id; }
        }

        private int falafelBalls;

        public int FalafelBalls
        {
            get { return falafelBalls; }
            
        }


        // Constructor
        public Falafel(int id,int falafelBalls)
        {
            this.id = id;
            this.falafelBalls = falafelBalls;
        }
    }
}
