using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CSharpEX15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Ex 15.");
            StartGame();
        }

        private static void StartGame()
        {
            string Input;
            Console.WriteLine("1.Single Threaded Cracker\n2.Multi-Threader Cracker\n3.Exit");
            Input = Console.ReadLine();

            if (Input == "1")
            {
                //single thread
                Sthread();
                Console.WriteLine("You picked a Single thread.");
                CodeCracker();
            }
            else if (Input == "2")
            {
                //multi thread
                MultiThread();
                Console.WriteLine("You picked a Multi thread.");
                CodeCracker();
            }
            else if (Input == "3")
            {
                //Exit game
                Console.WriteLine("Thank you for your time.");
            }
            else
            {
                //Error check
                Console.WriteLine("That isn't a valid input. Press something to continue.");
                Console.ReadLine();
                StartGame();
            }
        }

        private static void Sthread()
        {
            //1. write a program that generates all printable chars.
            //2. promp user to enter a password -> thay can choose the lenghts.
            //3. apply logic for the start time, crack the password, stop time.

            string input = Console.ReadLine();
            int ASCIIstart = 32;
            char[] ValidChar = new char[95];
            string ValidGuess = "";
            for (int start = 0; start < 95; start++)
            {
                ValidChar[start] = (char)ASCIIstart;
                ASCIIstart++;
            }
            Dive("", 0, input, ValidChar, ValidGuess);
        }

        private static void CodeCracker()
        {
            Console.WriteLine("Please enter a password:");
            string input = Console.ReadLine();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            BreakthePassW(input);
            watch.Stop();
            Console.WriteLine($"Single Thread is completed in {watch.Elapsed}.");
            watch.Reset();
            watch.Start();
            MultiThread();
            watch.Stop();
            Console.WriteLine($"Multi-Thread completed in {watch.Elapsed}.");
        }

        private static void MultiThread()
        {
            string input = Console.ReadLine();
            int ASCIIstart = 32;
            char[] ValidChar = new char[95];
            string ValidGuess = "";
            for (int start = 0; start < 95; start++)
            {
                ValidChar[start] = (char)ASCIIstart;
                ASCIIstart++;
            }
            DiveParra("", 0, input, ValidChar, ValidGuess);
        }

        private static void DiveParra(string prefix, int level, string input, char[] ValidChar, string ValidGuess)
        {
            level++;
            Parallel.ForEach(ValidChar, MultiChar =>
            {
                foreach (var item in ValidChar)
                {
                    ValidGuess = prefix + MultiChar;
                    if (ValidGuess == input)
                    {
                        Console.WriteLine($"Password match found, your password is: {ValidGuess}");
                    }
                    if (level < input.Length)
                    {
                        Dive(prefix + MultiChar, level, input, ValidChar, ValidGuess);
                    }
                }

            });
        }

        private static void BreakthePassW(string input)
        {
            int ASCIIstart = 32;
            char[] ValidChar = new char[95];
            string ValidGuess = "";
            for (int start = 0; start < 95; start++)
            {
                ValidChar[start] = (char)ASCIIstart;
                ASCIIstart++;
            }
            Dive("", 0, input, ValidChar, ValidGuess);

        }

        private static void Dive(string prefix, int level, string input, char[] ValidChar, string ValidGuess)
        {
            level++;
            foreach (var item in ValidChar)
            {
                ValidGuess = prefix + item;
                if (ValidGuess == input)
                {
                    Console.WriteLine($"Password match found, your password is: {ValidGuess}");
                }
                if (level < input.Length)
                {
                    Dive(prefix + item, level, input, ValidChar, ValidGuess);
                }
            }
        }
    }
}
