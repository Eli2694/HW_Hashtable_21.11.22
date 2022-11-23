using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HW_Hashtable_21._11._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singelton food =  Singelton.Instance();
            Hashtable ret = food.LoadTable();
            food.searchForTheKey(ret);


            Console.ReadLine();
        }
    }
}
