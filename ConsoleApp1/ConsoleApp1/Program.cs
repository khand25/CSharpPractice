// See https://aka.ms/new-console-template for more information
using System;
// name of C# sharp project for namespace is ConsoleApp1 which is required for any C# sharp code.
// similar to packages from Java
namespace ConsoleApp1
{

    // Name of C# class which is called Program.cs
    class Program
    {



        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Yo");
            string message = Console.ReadLine();
            Console.WriteLine($"You entered this message: {message}");
            // the Write function is like a Java print statement where it prints
            // content to the console BUT DOES NOT PASTE A NEW LINE CHARACTER AT THE
            //END.
            Console.Write("Stay on the same line");
            Console.WriteLine("Test");

            // This is a comment

            /*
            *
            * This is
            * a multline 
            * comment
            */

            Console.WriteLine("\tDanyal");
            Test t = new Test();
            t.Hello();
            Variables.Test();
            //Console.Beep();

        }
    }

    class Test
    {
        public void Hello()
        {
            Console.WriteLine("Yo from the \'Test\' class");
        }
    }

    public class Variables
    {
        // public defualt construcotr just for reference
        public Variables()
        {

        }

        public static void Test()
        {
            // intialize and declare an int varaible called age that will hold
            // the value of 23.
            // Since age is an int primitve type varialbe, then the value of 23,
            // will be stored at the age varaible container in memory.
            int age = 23;
            // created a long variable called bigNumber
            long bigNumber = 90000000L;
            Console.WriteLine($"Age variable value: {age}, and bigNumber value: {bigNumber}");

            //Decimal datatypes are double by defualt
            double negative = -55.20;
            float precision = 5.000001F;
            Console.WriteLine($"negative variable value: {negative}, and precision value: {precision}");
            // good for currency values
            decimal money = 14.99M;
            Console.WriteLine($"negative variable value: {negative}, and precision value: {precision} and money value: {money}");

            //int x = 20;
            //int y = 19;
            //int z = 18;

            int x = 20, y = 19, z = 18;

            /** Textual datatypes!! */
            // string datatype
            string name = "Danyal";
            // char datatype
            char letter = 'a';
            Console.WriteLine($"Your name is {name}");
            // Converting Strings and numbers!

        }
       
     } //class: Variables
}

