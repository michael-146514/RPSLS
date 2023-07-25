using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;
       public int numPlayers;
       public int rounds = 1;
        
        //Constructor
        public Game()
        {
            RunGame();
           
        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n Rock crushes Scissors\n Scissors cuts Paper \n Paper covers Rock\n Rock crushes Lizard\n Lizard poisons Spock\n Spock smashes Scissors\n Scissors decapitates Lizard\n Lizard eats Paper\n Paper disproves Spock\n Spock vaporizes Rock\n");
        }

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("How many human players? (1 or 2)");
            int num = Convert.ToInt32(Console.ReadLine());
            numPlayers = num;
            return numPlayers;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            if(numberOfHumanPlayers == 2)
            {
              
                playerOne = new HumanPlayer("player One");
                playerOne.PickName();
                playerTwo = new HumanPlayer("Player Two");
                playerTwo.PickName();
            }else if(numberOfHumanPlayers == 1)
            {
                playerOne = new HumanPlayer("player One");
                playerOne.PickName();
                playerTwo = new ComputerPlayer("Computer Robo");
            }
            else
            {
                Console.WriteLine("Invalid Number!! Please Enter 1 or 2");
            }
        }

        public void CompareGestures()
        {
            if (playerOne.chosenGesture == "Rock" && playerTwo.chosenGesture == "Scissors")
            {
                Console.WriteLine($"{playerOne.name} Wins this round!");
                playerOne.score++;
            }
            else if (playerOne.chosenGesture == "Scissors" && playerTwo.chosenGesture == "Paper")
            {
                Console.WriteLine($"{playerOne.name} Wins this round!");
                playerOne.score++;
            }
            else if (playerOne.chosenGesture == "Paper" && playerTwo.chosenGesture == "Rock")
            {
                Console.WriteLine($"{playerOne.name} Wins this round!");
                playerOne.score++;
            }
            else if (playerOne.chosenGesture == "Rock" && playerTwo.chosenGesture == "Lizard")
            {
                Console.WriteLine($"{playerOne.name} Wins this round!");
                playerOne.score++;
            }
            else if (playerOne.chosenGesture == "Lizard" && playerTwo.chosenGesture == "Spock")
            {
                Console.WriteLine($"{playerOne.name} Wins this round!");
                playerOne.score++;
            }
            else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "Scissors")
            {
                Console.WriteLine($"{playerOne.name} Wins this round!");
                playerOne.score++;
            }
            else if (playerOne.chosenGesture == "Scissors" && playerTwo.chosenGesture == "Lizard")
            {
                Console.WriteLine($"{playerOne.name} Wins this round!");
                playerOne.score++;
            }
            else if (playerOne.chosenGesture == "Lizard" && playerTwo.chosenGesture == "Paper")
            {
                Console.WriteLine($"{playerOne.name} Wins this round!");
                playerOne.score++;
            }
            else if (playerOne.chosenGesture == "Paper" && playerTwo.chosenGesture == "Spock")
            {
                Console.WriteLine($"{playerOne.name} Wins this round!");
                playerOne.score++;
            }
            else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "Rock")
            {
                Console.WriteLine($"{playerOne.name} Wins this round!");
                playerOne.score++;
            }
            else if (playerTwo.chosenGesture == "Rock" && playerOne.chosenGesture == "Scissors")
            {
                Console.WriteLine($"{playerTwo.name} Wins this round!");
                playerTwo.score++;
            }
            else if (playerTwo.chosenGesture == "Scissors" && playerOne.chosenGesture == "Paper")
            {
                Console.WriteLine($"{playerTwo.name} Wins this round!");
                playerTwo.score++;
            }
            else if (playerTwo.chosenGesture == "Paper" && playerOne.chosenGesture == "Rock")
            {
                Console.WriteLine($"{playerTwo.name} Wins this round!");
                playerTwo.score++;
            }
            else if (playerTwo.chosenGesture == "Rock" && playerOne.chosenGesture == "Lizard")
            {
                Console.WriteLine($"{playerTwo.name} Wins this round!");
                playerTwo.score++;
            }
            else if (playerTwo.chosenGesture == "Lizard" && playerOne.chosenGesture == "Spock")
            {
                Console.WriteLine($"{playerTwo.name} Wins this round!");
                playerTwo.score++;
            }
            else if (playerTwo.chosenGesture == "Spock" && playerOne.chosenGesture == "Scissors")
            {
                Console.WriteLine($"{playerTwo.name} Wins this round!");
                playerTwo.score++;
            }
            else if (playerTwo.chosenGesture == "Scissors" && playerOne.chosenGesture == "Lizard")
            {
                Console.WriteLine($"{playerTwo.name} Wins this round!");
                playerTwo.score++;
            }
            else if (playerTwo.chosenGesture == "Lizard" && playerOne.chosenGesture == "Paper")
            {
                Console.WriteLine($"{playerTwo.name} Wins this round!");
                playerTwo.score++;
            }
            else if (playerTwo.chosenGesture == "Paper" && playerOne.chosenGesture == "Spock")
            {
                Console.WriteLine($"{playerTwo.name} Wins this round!");
                playerTwo.score++;
            }
            else if (playerTwo.chosenGesture == "Spock" && playerOne.chosenGesture == "Rock")
            {
                Console.WriteLine($"{playerTwo.name} Wins this round!");
                playerTwo.score++;
            }
            else
            {
                Console.WriteLine("It's a tie :(");
            }
        }

        public void DisplayGameWinner()
        {
            if (playerOne.score > playerTwo.score)
            {
                Console.WriteLine($"Congrats {playerOne.name} Wins!!!");
            }
            else if (playerTwo.score > playerOne.score)
            {
                Console.WriteLine($"Congrats {playerTwo.name} Wins!!!");
            }
            else
            {
                Console.WriteLine("It's a tie!!! :(");
            }
        }

        public void RunGame()
        {
            WelcomeMessage();
            ChooseNumberOfHumanPlayers();
            numberOfRounds();
            CreatePlayerObjects(numPlayers);

            for(int i = 1; i <= rounds; i++)
            {
              playerOne.ChooseGesture();
              playerTwo.ChooseGesture();
              CompareGestures();
              displayPoints();
            }

            DisplayGameWinner();

        }

        public int numberOfRounds()
        {
            Console.WriteLine("How many rounds do you want to play?");
            int rounds = Convert.ToInt32(Console.ReadLine());
            this.rounds = rounds;
            return rounds;
        }

        public void displayPoints()
        {
            Console.WriteLine($"{playerOne.name} has {playerOne.score} points, {playerTwo.name} has {playerTwo.score} points!");
        }
    }
}
