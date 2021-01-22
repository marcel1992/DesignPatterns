using System;

namespace FacadePattern
{
    public class RobotBody
    {
        RobotType _robotType;

        //to keep a count of number of robots

        static int count = 0;
        public RobotBody(RobotType robotType)
        {
            _robotType = robotType;
        }

        public void MakeRobotBody()
        {
            Console.WriteLine($"Constructing one {_robotType} robot.");
            Console.WriteLine("Robot creation finished.");
            Console.WriteLine($"Total number of robot created at this moment= {++count}");
        }

        public void DestroyRobotBody()
        {
            if(count > 0)
            {
                --count;
                Console.WriteLine("Robot's destruction process is over.");
            }
            else
            {
                Console.WriteLine("All robots are destroyed.");
                Console.WriteLine("Color removal operation will not continue.");
            }
        }
    }
}
