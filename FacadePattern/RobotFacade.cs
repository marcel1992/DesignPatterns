namespace FacadePattern
{
    public class RobotFacade
    {
        RobotBody _robotBody;
        RobotColor _robotColor;

        public RobotFacade(RobotType robotType, string color = "steel")
        {
            _robotBody = new RobotBody(robotType);
            _robotColor = new RobotColor(color);
        }

        public void ConstructRobot()
        {
            System.Console.WriteLine("Robot creation through facade starts...");
            _robotBody.MakeRobotBody();
            _robotColor.SetColor();
            System.Console.WriteLine();
        }

        public void DestroyRobot()
        {
            System.Console.WriteLine("Making an attempt to destroy one robot using the facade now.");
            _robotColor.RemoveColor();
            _robotBody.DestroyRobotBody();
            System.Console.WriteLine();
        }
    }
}
