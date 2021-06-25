using System;

namespace CsharpEx02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sum of 10 numbers");
            int sum = SumTenInts(0, 0);
            Console.WriteLine($"The sum of ten integers is {sum}");

            Console.WriteLine("Average 10 numbers.");
            double avg = AvgTenInts(0, 1);
            char LetterGrade = 'X';
            LetterGrade = ConvertNumericToLetterGrade(avg);
            Console.WriteLine($"The average of ten integers is {avg} and the letter grade is {LetterGrade}");

            Console.WriteLine("Average user predetermined number of scores.");
            Console.WriteLine("How many scores do you wish to enter?");
            string noScores = Console.ReadLine();
            int numScores = int.Parse(noScores);
            double avg1 = AvgUnkInts(0, 1, numScores);
            LetterGrade = ConvertNumericToLetterGrade(avg1);
            Console.WriteLine($"The average of {numScores} integers is {avg1} and the letter grade is {LetterGrade}");

            Console.WriteLine("Average non-predetermined number of scores.");
            double avg2 = AvgAnyInts(0, 1);
            LetterGrade = ConvertNumericToLetterGrade(avg2);
            Console.WriteLine($"The average of ten integers is {avg2} and the letter grade is {LetterGrade}");
        }

        private static int SumTenInts(int sum, int count)
        {
            Console.WriteLine("Enter a score");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            if (count < 10)
                return SumTenInts(sum, count + 1);
            else
                return sum;
           
        }

        private static double AvgTenInts(int sum, int count)
        {
            Console.WriteLine("Enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            if (count < 10)
                return AvgTenInts(sum, count + 1);
            else

            return sum / count;

        }

        private static char ConvertNumericToLetterGrade(double Grade)
        {
            if (Grade >= 90 && Grade <= 100)
            {
                Console.WriteLine("A");
                Grade = 'A';
            }
             else if (Grade >= 80 && Grade <= 90)
            {
                Console.WriteLine("B");
                Grade = 'B';
            }
             else if (Grade >= 70 && Grade <= 80)
            {
                Console.WriteLine("C");
                Grade = 'C';
            }
            else if (Grade >= 60 && Grade <= 70)
            {
                Console.WriteLine("D");
                Grade = 'D';
            }
            else if (Grade < 60)
            {
                Console.WriteLine("F");
                Grade = 'F';
            }
            return (char)Grade;
                                  
        }


        private static double AvgUnkInts(int sum, int count, int numScores)
        {
            Console.WriteLine("Enter a score");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            if (count < numScores)
                return AvgUnkInts(sum, count + 1, numScores);
            else        
            return sum / count;


        }


        private static double AvgAnyInts(int sum, int count)
        {
            Console.WriteLine("Enter a score (enter Quit when complete); ");
            string input = Console.ReadLine();
            if (input == "Quit")
                return sum / --count;
            else
                sum += int.Parse(input);
            if (count > 0)
                return AvgAnyInts(sum, count + 1);
            else
                return sum / --count;

        }

    

        
    }
}
