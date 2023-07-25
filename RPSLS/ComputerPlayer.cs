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
            name = name;
        }



        public override void ChooseGesture()
        {
            var random = new Random();
            int rand = random.Next(gestures.Count);
            Console.WriteLine(rand);
        }

        public override void PickName()
        {

            name = "Computer Robo";
        }



    }
}
