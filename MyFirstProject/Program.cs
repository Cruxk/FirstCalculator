// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Numerics;

namespace MyFirstProject
{
    class Calculator
    {
        public int num1;
        public int num2;
        public int sum;
        public string input;
        
        public  void Add()
        {
            Console.WriteLine("Enter two numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine("Here is the answer: " + sum);
        }

        public void Subtract()
        {
            Console.WriteLine("Enter two numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 - num2;
            Console.WriteLine("Here is the answer: " + sum);
        }

        public void Divison()
        {
            Console.WriteLine("Enter two numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 / num2;
            Console.WriteLine("Here is the answer: " + sum);
        }

        public void Multiply()
        {
            Console.WriteLine("Enter two numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 * num2;
            Console.WriteLine("Here is the answer: " + sum);
            
            
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator1 = new Calculator();
            do
            {
                Console.WriteLine("Type Add, Subtract, Division, or Muyltiply");
                calculator1.input = Console.ReadLine();
            } 
            while (calculator1.input == null); 
            switch (calculator1.input)
            { 
                case "Add": 
                    calculator1.Add(); 
                    break; 
                case "Subtract":
                    calculator1.Subtract();
                    break;
                case "Division": 
                    calculator1.Divison();
                    break;
                case "Multiply":
                    calculator1.Multiply(); 
                    break;
                default: 
                    Console.WriteLine("That is not a valid input try again");
                    break;
            }
          
           
            Console.ReadKey();
        }
       


    }
}
