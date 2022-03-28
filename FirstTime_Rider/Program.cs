using System;

namespace FirstTime_Rider
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using different Types of lists
            
            //int Array

            int[] intArray = new int[4] {3, 4, 5, 2};
            
            // print out the numbers

            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }
            

        }
    }
}