using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {//Shaun Poweshiek

            //Declaring variables
            string userInput;
            int luckyNumber;
            bool validNumberCheck;


            //Checking for Lucky Number validity; if user enters invalid number, keep repeating loop.
            do
            {
                Console.WriteLine("Please enter your LUCKY NUMBER:");
                userInput = Console.ReadLine();
                validNumberCheck = int.TryParse(userInput, out luckyNumber);
                if (!validNumberCheck)
                    Console.WriteLine("Sorry, but FIZZBUZZ cannot run because you entered an invalid number");
            }
            while (!validNumberCheck);

            //Compare valid user input to FIZZBUZZ criteria.  Output lucky number + FIZZBUZZ message (if applicable).
            string validNumber;
            if (luckyNumber % 15 == 0) validNumber = luckyNumber + " ...FIZZBUZZ!!!";
            else if (luckyNumber % 3 == 0) validNumber = luckyNumber + " ...FIZZ!!!";
            else if (luckyNumber % 5 == 0) validNumber = luckyNumber + " ...BUZZ!!!";
            else validNumber = "" + luckyNumber;

            Console.WriteLine("Your valid lucky number = " + validNumber);
            Console.ReadLine();
                





        }
        }
    }

