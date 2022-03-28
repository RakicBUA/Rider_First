using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;

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
            
            //make a list of persons
            List<Person> persons = new List<Person>();
            Person a1= new Person{Name="Nemo",Age = 15};
            //add
            persons.Add(a1);
            //print
            foreach (var item in persons)
            {
                Console.WriteLine(item.Age+" "+item.Name);
            }

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