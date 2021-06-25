using System;

namespace IsraelCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. create new pack
            int[] newPack = new int[52];
            for (int i = 0; i < newPack.Length; i++)
                newPack[i] = i;

            printPack(newPack);
            Console.WriteLine("=======================");
            //2. shuffle pack
            Random r = new Random();
            for (int i = 0; i < newPack.Length; i++)
            {
                //pick a random number between 0 and 51
                int Rndm = r.Next(52);
                //swap i for the random number
                int temp = newPack[i];
                newPack[i] = newPack[Rndm];
                newPack[Rndm] = temp;

            }
            //3. print pack x2
            printPack(newPack);

        }

        private static void printPack(int[] newPack)
        {
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] values = {"Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"};
            foreach (int i in newPack)
            {
                Console.WriteLine($"{values[i % 13]} of {suits[i / 13]}");
            }
        }
    }
}
