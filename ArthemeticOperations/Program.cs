using System;

namespace ArthemeticOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Arthemetic Operations");
            while (true)
            {
                Console.WriteLine("Enter the option : 1) Addition");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Addition addition = new Addition();
                        addition.Add();
                        break;
                }
            }
        }
    }
}
