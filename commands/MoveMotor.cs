public class MoveMotor : Command
{
    private readonly int distance;

    public MoveMotor(int distance)
    {
        this.distance = distance;
    }

    public override void onExecute(Scanner scanner, Logger logger, CommandExecuter executer)
    {
        logger.Write($"motor start moving {distance}", Logger.LogLevel.DEBUG);
        scanner.Motor.MoveAbsolute(distance);
        logger.Write($"motor moved {distance}", Logger.LogLevel.DEBUG);
    }

    
}