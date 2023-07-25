using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class ComputerPlayer : Player
    {

        public ComputerPlayer(string name) : base(name)
        {
         
        }

        public override void ChooseGesture()
        {
            Random random = new Random();
            int rand = random.Next(gestures.Count);
            chosenGesture = gestures[rand]; 
            Console.WriteLine($"{name} picked {chosenGesture}");
        }

        public override void PickName()
        {
            name = "Computer Robo";
        }



    }
}
