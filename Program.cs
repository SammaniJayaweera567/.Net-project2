using System;

namespace SANUAPP01
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# comments(Single line & Multiline)

            /*Console.WriteLine("Number 1");
            Console.WriteLine("NUmber 2");*/



            //Variables declaration

            //string name;        //words
            //int age;            //whole numbers
            //float salary;       //decimals
            //double savemoney;   //decimals
            //char fueltype;      //single letter(character)
            //bool maritalStatus; //true or false




            //casting (eka data type ekaka tiyena variable ekak wena data type ekakata change kara ganima)
            //implicit casting(automatically cast)
            //explicit casting(manually cast)

            //implicit casting

            //int number;    //(= assign the right side value equal to left side value)   variable declaration
            //number = 10;    // variable initialize

            //or

            //int number = 10;            //variable declare and initialization

            //double numberConverted = number;        //int  converted to double

            //Console.WriteLine(number);
            //Console.WriteLine(numberConverted);


            //explicit casting

            //double number = 10.5;
            //int numberConverted = (int)number;
            //Console.WriteLine(number);
            //Console.WriteLine(numberConverted);




            //Keyboard input

            //string name;

            //Console.Write("Please Enter your Name :");
            //name = Console.ReadLine();

            //Console.WriteLine("Your Name is : " + name);
            //Console.ReadLine();



            //string name;

            //Console.Write("Please Enter your name :");
            //name = Console.ReadLine();

            //Console.Write("Your Age :");
            //int age = Int16.Parse(Console.ReadLine());          //age kiyana variable eka hadala nathi nisa

            //Console.WriteLine("Your Age is :" + age);

            //Console.WriteLine("Your Name is : " + name);
            



            //C# Operators
            //Arithmetic operator

            int number1 = 10;
            int number2 = 20;

            Console.WriteLine(number1 + number2);
            Console.WriteLine(number1 - number2);
            Console.WriteLine(number1 * number2);
            Console.WriteLine(number1 / number2);
            Console.WriteLine(number1 % number2);
            Console.WriteLine(number1++);
            Console.WriteLine(number1--);
            Console.WriteLine(number1 / (double)number2);

            Console.ReadLine();














        }
    }
}
