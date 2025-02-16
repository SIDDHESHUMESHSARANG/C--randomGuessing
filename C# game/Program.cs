
namespace myfirstproject
{
    class Program
    {
        private static void Main(string[] args)
        {
            Random num = new Random();
            int randomNum = num.Next(1, 101);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to the random number guessing game.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Before getting started, Here are some rules for this game: .");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. Guess the number between 1 and 100" +
                "\n2.If your guess is higher than the generated number, you will se 'Too High'" +
                "\n3.If your guess is lower than the generated number, you will se 'Too Low'" +
                "\n4.To quit the game, enter '0'" +
                "\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Now Sit back, Relax, and Enjoy the Game.");
            Console.WriteLine("\n");
            bool guess = false;

            while (!guess)
            {
                Console.WriteLine("Guess the Number (1-100): ");
                int userNum = Convert.ToInt32(Console.ReadLine());

                if (userNum == randomNum)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Bingo!!! You Guessed it right!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("It's been a real pleasure to play this game with you, Thank you! \n" +
                        "And don't forget to show your support by starring this repository on Github.");
                    Console.ReadKey();
                    guess = true;
                    break;
                }

                if (userNum == 0)
                {
                    Console.WriteLine("Quitting the game...");
                    Console.WriteLine("You have exited the game succesfully");
                    Console.WriteLine("It's been a real pleasure playing with you. Thanks!!!");
                    break;
                }

                else if (userNum > randomNum)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Too High");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                  
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Too Low");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
            }
        }
    }
}
