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
            //Console.Beep();

        }
    }
}

