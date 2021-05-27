using System;

namespace NumberGuesser
{
    class Program
    {
        //Code along from a teaching video on YT, Create A Number Guessing Game in C#
        static void Main(string[] args)
        {
            Random r = new Random();
            int winNum = r.Next(1, 100);
            bool win = false;
            do//do is a code snippet for the while() loop
            {
                Console.WriteLine("Guess a number in between 0 and 100.");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if(i > winNum)
                {
                    Console.WriteLine("Too high! Guess lower!");
                }
                else if(i < winNum)
                {
                    Console.WriteLine("Too low! Guess higher!");
                }
                else if(i == winNum)
                {
                    Console.WriteLine("YOU WIN!");
                    win = true;
                }
            }
            while(win == false);


        }
    }
}
