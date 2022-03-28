using System;
using System.Collections;

namespace FirstTime_Rider
{
    public class List
    {
       ArrayList students = new ArrayList();

       public ArrayList Students
       {
           get => students;
           set => students = value;
       }

       public void Print()
       {
           foreach (var item     in students)
           {
               Console.WriteLine(item);
           }
       }
       
       
    }
}