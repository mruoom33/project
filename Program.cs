using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace تعديل
{
    class Program
    {
        static void Main(string[] args)
        {

            int targetNumber = 25; 
            int maxAttempts = 3;   
            int attempts = 0;
            int userNumber;

            Console.WriteLine("you have three attempts to guess the correct number.!");

            while (attempts < maxAttempts)
            {
                Console.Write("Enter your number: ");
                string input = Console.ReadLine();

               
                if (int.TryParse(input, out userNumber))
                {
                    if (userNumber == targetNumber)
                    {
                        Console.WriteLine("congratulation!The number you entered matches the target number.");
                        Console.ReadLine();
                        break;
                    }
               
                else if (userNumber > targetNumber)
                        {
                            Console.WriteLine("The number you entered is greater than the target number.");
                        }
                        else
                        {
                            Console.WriteLine("The number you entered is  than the target number.");
                        }

                        attempts++; 
                        Console.WriteLine($"you have remaining  {maxAttempts - attempts} attempts.");
                    }
                    else
                    {
                        Console.WriteLine("please enter a valid number.");
                    }

                    if (attempts == maxAttempts)
                    {
                        Console.WriteLine("sorry you have exhausted all your attempts!");
                    Console.ReadLine();
                 
                    }
                }
            }

        }
                    
                
           
    }



