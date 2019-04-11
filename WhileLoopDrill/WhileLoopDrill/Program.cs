using System;


namespace WhileLoopDrill
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input an integer (x) into the function to receive an output (y)");
            Console.WriteLine("The function follows the formula y = f(x) + b");
            Console.WriteLine("Input a value that outputs 0 in 10 turns or fewer!");
            int x;
            int y = 1;
            int guesses = 0;

            do
            {
                x = Convert.ToInt32(Console.ReadLine());
                y = -4 * (x * x) + 2116;
                Console.WriteLine("The output is " + y);
                guesses++;
                while(guesses > 6)
                {
                    Console.WriteLine((10-guesses) + " guesses left!");
                    break;
                }
                if(y == 0)
                {
                    Console.WriteLine("Congratulations! You found the number!");
                    break;
                }
                if(guesses == 10)
                {
                    Console.WriteLine("Sorry! Looks like you ran our of guesses.");
                    break;
                }
            }
            while (guesses < 10);
            Console.WriteLine("Thanks for Playing!");
            Console.Read();
        }
    }
}
