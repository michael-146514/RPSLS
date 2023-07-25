using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name)
        {
            this.name = name;
            this.score = score;
            this.chosenGesture = chosenGesture;
        }

        public override void ChooseGesture()
        {
            Console.WriteLine($"{name} Pick a Gesture, rock, paper, scissors, lizard, Spock");
            chosenGesture = Console.ReadLine();
        }

         public override void PickName()
        {
            Console.WriteLine($"{name} Please enter your name");
            name = Console.ReadLine();
        }

    }
}
