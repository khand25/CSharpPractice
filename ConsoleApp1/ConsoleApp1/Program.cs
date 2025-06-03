// See https://aka.ms/new-console-template for more information
using System;
using System.Formats.Asn1;
// name of C# sharp project for namespace is ConsoleApp1 which is required for any C# sharp code.
// similar to packages from Java
namespace ConsoleApp1
{

    // Name of C# class which is called Program.cs
    class Program
    {

        // Youtube tutorial link: https://www.youtube.com/@CoffeeNCode

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

            //Decimal datatypes are double by defualt!
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

            /** 
            *Textual datatypes!! 
            */
            // string datatype
            string name = "Danyal";
            // char datatype
            char letter = 'a';
            Console.WriteLine($"Your name is {name}");

            // Converting Strings to numbers!
            string textAge = "-25";
            // similar to Java's Integer.parseInt() function!
            age = Convert.ToInt32(textAge);
            Console.WriteLine(age);
            // similar to Java's Long.parseLong() function!
            // note don't add 'L' at the end of the string literal otherwise an exception will be thrown
            bigNumber = Convert.ToInt64("9000000");
            Console.WriteLine(bigNumber);
            // similar to Java's Double.parseDouble() function!
            negative = Convert.ToDouble("-55.5");
            Console.WriteLine(negative);

            /**
            * Boolean dataype*/
            bool value = true;
            bool isMale = false;
            Console.WriteLine(value);
            Console.WriteLine(isMale);

            /**
            Operators
            */

            //int varaible
            age = 23;
            age++; //age = age + 1
            age = age + 10; //age = age + 10
            age += 10; // age = age + 10

            age--; //age = age - 1
            age = age - 10; //age = age - 10
            age -= 10; // age = age - 10

            age = 23;
            age *= 10; // age = age * 10;
            age = 23;
            age /= 10; // age = age / 10 which is 2 as we are doing INTEER division and the decimal points truncates
            Console.WriteLine($"The modified age is now {age}");
            name = "Aba"; // which is a string vairalbe from above
            name += " loves programming in C#!"; // name = name + (concatenation) " loves programming in C#!"
            Console.WriteLine($"The name variable value is now: {name}");

            /**
            *Remainders in C# 
            */
            int firstNum = 10;
            int secondNum = 3;
            Console.WriteLine(firstNum / secondNum); // 3
            Console.WriteLine(firstNum % secondNum); // 10 %3 is 1 as 10/3 has a remiander of 1.

            /*** 
            Var keyword
            */

            // var keyword can be used for the compiler to implicitly recognize and
            // figure out what a specific varaible's datatype will be if not given explicitly
            var newAge = 43; //here newAge is a varaible that the compiler will implicitly
                             // make it into an int based upon the special var keyword used
            Console.WriteLine($"New age value {newAge}");

            /**
            Const keyword
            */
            // const keyword is used to make a varaible to NOT BE ABLE TO CHANGE ITS VALUE OR BE REASSIGNED TO A NEW VALUE AFTER BEING INTIALIZED.

            const double pi = 3.14;
            // code below won't compile as pi variable can be reassinged a new value as it is a constant varaible type
            //pi = 4.5;
            Console.WriteLine($"Pi value in Math: {pi}");
        }   //Test function 
       
     } //class: Variables
}

