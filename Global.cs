public static class Global {

    public Scanner Scanner { get; }
    public Logger Logger { get; }
    public CommandExecuter CommandExecuter { get; }
    private Global instace;
    private Global(){
        Scanner = new();
        Logger = new("path");
        Logger.LogLevel = Logger.LogLevel.DEBUG;
        CommandExecuter = new(scanner, logger);
    }

    public static Global getInstance(){
        if (this.instace == null)
            this.instace = new Global();
        return instanse;
    }

}