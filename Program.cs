using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ConsoleApp1
{
    internal class Program
    {

        class Number
        {
            public int Value;
        }
        static void Main(string[] args)
        {

            ///*Write a program that allows the user to enter a number then print it.*/
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You entered: {number}");

            ///*Write C# program that Assigning one value type variable to another and 
            // modifying the value of one variable and mention what will happen */
            int a = 5;
            int b = 10;
            Console.WriteLine($"Value of a = {a} , Value of b = {b}"); //a= 5 b =10 each one has differnet address in stack
            //after assign
            b = a;
            Console.WriteLine($"Value of a = {a} , Value of b = {b}"); //a= 5 b = 5 each one has differnet address in stack and same as before 
            //after modifying 
            a = 20;
            Console.WriteLine($"Value of a = {a} , Value of b = {b}"); //a= 20 b = 5 each one has differnet address in stack and same as before 

            ///*Write C# program that Assigning one reference type variable to another and 
            //  modifying the object through one variable and mention what will happen*/


            Number num1 = new Number();
            Number num2 = new Number();

            num1.Value = 10;
            num2.Value = 5;

            Console.WriteLine($"num1.Value = {num1.Value}, num2.Value = {num2.Value}");//num 1 = 10 ,num2 = 5 each has different location in meomry 

            ////After assign
            num2 = num1;
            Console.WriteLine($"num1.Value = {num1.Value}, num2.Value = {num2.Value}");//num 1 = 10 ,num2 = 10 each has the same meomry location

            //After modifying
            num2.Value = 50;
            Console.WriteLine($"num1.Value = {num1.Value}, num2.Value = {num2.Value}");//num 1 = 50 ,num2 = 50 each has the same meomry location

        }
    }




}



