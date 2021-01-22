using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Facade Pattern");

            //making a milano robot with green color
            RobotFacade robotFacade = new RobotFacade(RobotType.Milano, "green");
            robotFacade.ConstructRobot();

            //making a robonaut robot with default steel color
            robotFacade = new RobotFacade(RobotType.Robonaut);
            robotFacade.ConstructRobot();

            //destroy one robot
            robotFacade.DestroyRobot();

            //destroy another robot
            robotFacade.DestroyRobot();

            //this attempt should fail
            robotFacade.DestroyRobot();
            Console.Read();
        }
    }
}
