using System;
using System.IO;

namespace COMP123Examples
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Person moon = new Person("Moon", "Mun");
            //Console.WriteLine(moon.GetFullName());
            //moon.FirstName = "Bob";
            //Console.WriteLine(moon.GetFullName());
            //moon.Age = 23;
            //Console.WriteLine(moon.Age);

            ////static method call
            //Console.WriteLine(Person.GetWords());

            //4th week class
            Person moon = new Person("Moon", "Munn");
            moon.SaveToFile("c:\\drew\\drew2.txt");

        }

        //public static int AddNumbers(int number1,int number2)
        //{
        //    return number1 + number2;
        //}


        


    }
}
