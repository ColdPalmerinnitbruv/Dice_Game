namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 7);
            int playerScore = 0;
            int dealerScore = 0;
            bool playerTurn = true;

            while (true)
            {
                if (playerTurn)
                {
                    Console.WriteLine($"Din poäng: {playerScore}");
                    Console.WriteLine("Vill du slå tärningen? (ja/nej)");
                    string response = Console.ReadLine().ToLower();

                    if (response == "ja")
                    {
                        int roll = rand.Next(1, 7);
                        playerScore += roll;
                        Console.WriteLine($"Du slog {roll}. Din nya poäng är {playerScore}.");

                        if (playerScore > 21)
                        {
                            Console.WriteLine("Du har överstigit 21! Du förlorar.");
                            return;
                        }
                    }
                    else
                    {
                        playerTurn = false;
                    }
                }
                else
                {
                    Console.WriteLine($"Dealerns poäng: {dealerScore}");
                    if (dealerScore < 17)
                    {
                        int roll = rand.Next(1, 7);
                        dealerScore += roll;
                        Console.WriteLine($"Dealern slog {roll}. Dealerns nya poäng är {dealerScore}.");

                        if (dealerScore > 21)
                        {
                            Console.WriteLine("Dealern har överstigit 21! Du vinner!");
                            return;
                        }
                    }
                    else
                    {
                        break; // Dealern stannar
                    }
                }
            }

            Console.WriteLine($"Din poäng: {playerScore}, Dealerns poäng: {dealerScore}");
            if (playerScore > dealerScore)
            {
                Console.WriteLine("Du vinner!");
            }
            else if (playerScore < dealerScore)
            {
                Console.WriteLine("Dealern vinner!!!");
            }
            else
            {
                Console.WriteLine("Det blev oavgjort!");
            }











        }
    }
}