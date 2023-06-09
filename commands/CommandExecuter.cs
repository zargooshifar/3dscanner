public class CommandExecuter {
    private readonly Scanner scanner;
    private readonly Logger logger;

    public CommandExecuter(Scanner scanner, Logger logger){
        this.scanner = scanner;
        this.logger = logger;
    }

    public void ExecuteCommand(Command cmd){
        cmd.onExecute(scanner, logger, this);
    }
    public void ExecuteCommandBlocking(Command cmd);
    public void ExecuteMultipleCommand(Command[] cmds);
    public void ExecuteMultipleCommandParallel(Command[] cmds);
    
}