public abstract class Command {

    public abstract void onExecute(Scanner scanner, Logger logger, CommandExecuter executer);
}