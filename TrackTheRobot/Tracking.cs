using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackTheRobot
{
    public class Tracking
    {
        private int[,] Position = { {0 },{0 } };

        public int[,] TrackRobot(params string[] instructions)
        {
            Func<string, string> getDirection = direction=> direction.Split(" ")[0].ToLowerInvariant();
            Func<string, string> getValue = value => value.Split(" ")[1];
            foreach (var item in instructions)
            {
                if(getDirection(item) == "right")
                {
                    Position[0,0] +=Convert.ToInt32(getValue(item));
                }
                if (getDirection(item) == "left")
                {
                    Position[0, 0] -= Convert.ToInt32(getValue(item));
                }
                if (getDirection(item) == "up")
                {
                    Position[1, 0] += Convert.ToInt32(getValue(item));
                }
                if (getDirection(item) == "down")
                {
                    Position[1, 0] -= Convert.ToInt32(getValue(item));
                }
            }
            return Position;
        }
    }
}
