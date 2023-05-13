namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] arg)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;
            int playerScore = 0;
            int computerScore = 0;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";
                while (player != "rock" && player != "paper" && player != "scissors")
                {
                    System.Console.Write("Enter Rock, Paper or Scissors: ");
                    player = Console.ReadLine();
                    player = player.ToLower();
                }
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "rock";
                        break;
                    case 2:
                        computer = "paper";
                        break;
                    case 3:
                        computer = "scissors";
                        break;
                }
                System.Console.WriteLine("Player: " + player);
                System.Console.WriteLine("Computer: " + computer);
                switch (player)
                {
                    case "rock":
                        if (computer == "rock")
                        {
                            System.Console.WriteLine("It's a tie!");
                        }
                        else if (computer == "scissors")
                        {
                            System.Console.WriteLine("You win");
                            playerScore++;
                        }
                        else if (computer == "paper")
                        {
                            System.Console.WriteLine("You lost");
                            computerScore++;
                        }
                        break;
                    case "paper":
                        if (computer == "rock")
                        {
                            System.Console.WriteLine("You win!");
                            playerScore++;
                        }
                        else if (computer == "scissors")
                        {
                            System.Console.WriteLine("You lost");
                            computerScore++;
                        }
                        else if (computer == "paper")
                        {
                            System.Console.WriteLine("It's a tie!");
                        }
                        break;
                    case "scissors":
                        if (computer == "rock")
                        {
                            System.Console.WriteLine("You lost");
                            computerScore++;
                        }
                        else if (computer == "scissors")
                        {
                            System.Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "paper")
                        {
                            System.Console.WriteLine("You win!");
                            playerScore++;
                        }
                        break;
                }
                System.Console.WriteLine("Player " + playerScore + " - " + computerScore + " Computer");
                if (playerScore == 5)
                {
                    System.Console.WriteLine("You won! Would you like to play again (Y/N)");
                    answer = Console.ReadLine();
                    answer = answer.ToLower();
                    switch (answer)
                    {
                        case "y":
                            playAgain = true;
                            break;
                        case "n":
                            playAgain = false;
                            break;
                    }
                    System.Console.WriteLine("Thanks for playing ");
                }
                else if (computerScore == 5)
                {
                    System.Console.WriteLine("You lost! Would you like to play again (Y/N)");
                    answer = Console.ReadLine();
                    answer = answer.ToLower();
                    switch (answer)
                    {
                        case "y":
                            playAgain = true;
                            break;
                        case "n":
                            playAgain = false;
                            break;
                    }
                    System.Console.WriteLine("Thanks for playing ");
                }

            }
        }
    }
}