public class InitializeAll : Command
{

    public InitializeAll()
    {
    }

    public override void onExecute(Scanner scanner, Logger logger, CommandExecuter executer)
    {
        logger.Write($"initializing Camera1", Logger.LogLevel.DEBUG);
        scanner.Camera1.Initialize();
        logger.Write($"initializing Camera2", Logger.LogLevel.DEBUG);
        scanner.Camera2.Initialize();
        logger.Write($"initializing Motor", Logger.LogLevel.DEBUG);
        scanner.Motor.Initialize();
        logger.Write($"initializing DoorSensor", Logger.LogLevel.DEBUG);
        scanner.DoorSensor.Initialize();
        logger.Write($"initializing LineLaser", Logger.LogLevel.DEBUG);
        scanner.LineLaser.Initialize();
        logger.Write($"initializing Scale", Logger.LogLevel.DEBUG);
        scanner.Scale.Initialize();

        scanner.Initialize();
    }

    
}