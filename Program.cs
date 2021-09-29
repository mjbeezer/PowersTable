using System;

namespace Exponents_Powers_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            bool program = true;
            while (program == true)
            {
                //ask for user input, assume this is valid data. Extra challenge being confine user choices to integers between 0 and 1290
                Console.WriteLine("Welcome to The Powers Table! Please enter an integer.");
                int number = int.Parse(Console.ReadLine());

                if (number <= 0 || number > 1290)
                {
                    Console.WriteLine("Your number is outside the range of acceptable integers. Please choose again!");
                    continue;
                }

                //display table of powers
                PowerTable(number);

                //ask user if they wish to continue, only continue if user agrees
                Console.WriteLine("Do you wish to continue squaring and cubing? y/n");
                string resume = Console.ReadLine().ToLower();
                if (resume == "n")
                {
                    program = false;
                }
            }
      
        }

        //mathematical quations for squared and cubed
        public static void PowerTable(int number)
        {
            Console.WriteLine($"Integer\tSquare\tCubed");
            Console.WriteLine($"======\t======\t======");
            for (int i = 1; i <= number; i++)
            {
                int square = i * i;
                int cube = i * i * i;                
                Console.WriteLine($" {i, 5}\t {square, 5}\t {cube, 5}\t");
            }            
        }
    }
}
