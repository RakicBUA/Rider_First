using System;

namespace FirstTime_Rider
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using different Types of lists
            
            //int Array

            int[] intArray = new int[] {3, 4, 5, 2};
            //method
            Printout(intArray);

        }

        private static void Printout(int[] intArray)
        { // print out
            foreach (var item in intArray)
            {
                Console.WriteLine("the numbers are: "+ item);
            }
        }
    }
}