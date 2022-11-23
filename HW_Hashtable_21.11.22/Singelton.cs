using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HW_Hashtable_21._11._22
{
    internal class Singelton
    {
        // variable of type Singelton

        static Singelton instance;

        // Constructor
        protected Singelton()
        {

        }

        // Function Create object of singelton

        public static Singelton Instance()
        {
            if(instance == null)
            {
                instance = new Singelton(); 
            }
            return instance;
        }

        

        // generate random numbers
        Random random = new Random(DateTime.Now.Millisecond);

        // Function =>  Fill HashTable

        public Hashtable LoadTable()
        {
            // Create instance/object Hashtable
            Hashtable myTable = new Hashtable();

            for (int i = 1; i < 1000; i++)
            {
                int rnd = random.Next(100, 10000);
                if(rnd % 2 == 0)
                {
                    if (!myTable.ContainsKey(rnd))
                    {
                        myTable.Add(rnd, new Falafel(rnd, random.Next(1, 5)));
                    }
                        
                }
                else
                {
                    if (!myTable.ContainsKey(rnd))
                    {
                        myTable.Add(rnd, new iceCream(rnd, random.Next(1, 5)));
                    }
                        
                }
            }

            return myTable; 
        }

        // Function - Search if the key exists

        public void searchForTheKey(Hashtable myTable)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Enter a key");
                int key = int.Parse(Console.ReadLine());

                if (myTable.ContainsKey(key))
                {
                    Console.WriteLine("The key exists in hashtable");
                    if(myTable[key] is Falafel)
                    {
                        Falafel myFalafel = (Falafel)myTable[key];
                        Console.WriteLine("This Falafel Has {0} balls", myFalafel.FalafelBalls);
                    }
                    else
                    {
                        iceCream myIceCream = (iceCream)myTable[key];   
                        Console.WriteLine("This iceCream Has {0} balls", myIceCream.IcecreamBalls);
                    }
                }
                else
                {
                    Console.WriteLine("The key does not exists in hashtable");
                }
            }

            
        }
    }
}
