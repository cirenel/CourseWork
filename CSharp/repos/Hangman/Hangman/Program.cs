using System;

namespace Hangman
{
    class Program
    {

        static void Main(string[] args)
        {
            string play = "";
            string[] words = {"apple", "bobbypin", "cat", "dreamed","ephemeral", "fleace", "good","hemolytic","invention","jokingly","kelp", "lozenge","millstone", "notebook", "openable", "persimmon","queen","rockingchair","soda","television","uvula","violon","wobble","xenomorph","yodel","zebra" };
            do {
                Console.Clear();
                Random r = new Random();
                //Console.Write("Give me a word.... ");
                int i = ((int)(r.NextDouble() * words.Length));
              //  Console.WriteLine(i);
                string input = words[i]; ;//Console.ReadLine();
           // Console.Clear();

            Game hangman = new Game(input);


            while (!hangman.Over())
            {
                Console.WriteLine(hangman);
                Console.Write("Give me a letter: ");
                hangman.Guess(Console.ReadLine().ToCharArray()[0]);

            }
            Console.WriteLine(hangman);
            if (hangman.Won())
            {
                Console.WriteLine("Congrats!! You won in {0} guesses!", hangman.NumGuesses);
            } else if (hangman.Lost())
            {
                Console.WriteLine("You lost. that sucks..... the correct word was " + hangman.Word);
            }
            Console.WriteLine("Play again? Y|N");
            play = Console.ReadLine();
        } while (play == "y" || play == "Y" || play == "YES" || play == "yes") ;

        }
    }
}
