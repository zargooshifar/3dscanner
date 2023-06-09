public class ProccessLaserImage : Command
{
    private readonly Bitmap bitmap1;
    private readonly Bitmap bitmap2;
    Stopwatch stopwatch;
    public ProccessLaserImage(Bitmap bitmap1, Bitmap bitmap2)
    {
        this.bitmap1 = bitmap1;
        this.bitmap2 = bitmap2;
    }


    public override void onExecute(Scanner scanner, Logger logger, CommandExecuter executer)
    {
        stopwatch = new();
        stopwatch.Start();

        logger.Write("start proccessing...");
        //processing...

        logger.Write($"proccessing done in {Stopwatch.ElapsedMilliseconds} ms!", Logger.LogLevel.DEBUG);

    }

 
}