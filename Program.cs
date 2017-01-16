using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleAppForTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare the first array for ints and give it values
            int[] array = new int[5] { 1,2,5,4,5 };

            //declare the second array for strings and give it values
            string[] array2 = array2 = new string[5] { "mary", "joe", "sarah", "abigale", "bailey" };

            //declare the third array for ints and give it values
            int[] array3 = new int[10] {1,2,3,4,5,5,4,3,2,1};
            
            //unsorted printing of the first array
            foreach (int i in array)
            {
                 Console.WriteLine("{0}", i);

            }
            Console.ReadKey();

            //sorted printing of the first array
            foreach (int i in array)
            {
                Array.Sort(array); //sorts the array and then proceeds to print out the results of the sort
                Console.WriteLine("{0}",i);
                
            }
            Console.ReadKey();

            //unsorted printing of the second array
            foreach (string names in array2)
            {
                Console.WriteLine("{0}",names);

            }
            Console.ReadKey();

            //sorted printing of the second array
            Array.Sort(array2, StringComparer.InvariantCulture);//sorts the array 
            foreach (string names in array2)
            { 
                Console.WriteLine("{0}", names);

            }
            Console.ReadKey();

            //unsorted printing of the third array
            foreach (int i in array3)
            {
                Console.WriteLine("{0}", i);

            }
            Console.ReadKey();

            //sorted printing of the third array
            foreach (int i in array3)
            {
                Array.Sort(array3); //sorts the array and then proceeds to print out the results of the sort
                Console.WriteLine("{0}", i);

            }
            Console.ReadKey();



        }
    }
}
