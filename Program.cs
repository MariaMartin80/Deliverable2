// Author: Maria Martin
// Date: 1/28/2021
//comments: This console application demostrates the use of conditional statement after getting input from users.

using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Score;
            Console.WriteLine("To check the grade you expect to get in ISM 4300, Please enter your Score: ");
            Score = Convert.ToInt32(Console.ReadLine());

            try
            {

                if ((Score >= 98) && (Score <= 100))
                {
                    Console.WriteLine("A+");
                }
                else if ((Score >= 92) && (Score <= 97))
                {
                    Console.WriteLine("A");
                }
                else if ((Score >= 90) && (Score <= 91))
                {
                    Console.WriteLine("A-");
                }
                else if ((Score >= 88) && (Score <= 89))
                {
                    Console.WriteLine("B+");
                }
                else if ((Score >= 82) && (Score <= 87))
                {
                    Console.WriteLine("B");
                }
                else if ((Score >= 80) && (Score <= 81))
                {
                    Console.WriteLine("B-");
                }
                else if ((Score >= 78) && (Score <= 79))
                {
                    Console.WriteLine("C+");
                }
                else if ((Score >= 72) && (Score <= 77))
                {
                    Console.WriteLine("C");
                }
                else if ((Score >= 70) && (Score <= 71))
                {
                    Console.WriteLine("C-");
                }
                else if ((Score >= 68) && (Score <= 69))
                {
                    Console.WriteLine("D+");
                }
                else if ((Score >= 62) && (Score <= 67))
                {
                    Console.WriteLine("D");
                }
                else if ((Score >= 60) && (Score <= 61))
                {
                    Console.WriteLine("D-");
                }
                else if ((Score < 60))
                {
                    Console.WriteLine("F");
                }
                Console.ReadLine();
            }

            catch
            {
                Console.WriteLine("Press any key to exit the program...");
                Console.WriteLine(true);
            }
        }
    }
}
