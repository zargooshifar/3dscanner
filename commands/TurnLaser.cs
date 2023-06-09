public class TurnLaser : Command
{
    private readonly bool on;

    public TurnLaser(bool on)
    {
        this.on = on;
    }

    public override void onExecute(Scanner scanner, Logger logger, CommandExecuter executer)
    {
        if(on)
           scanner.LineLaser.TurnOn();
        else
            scanner.LineLaser.TurnOff();
    }

    
}