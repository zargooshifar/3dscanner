public class App{

    void startapp(){
        var cmd = new InitializeAll();
        Global.getInstance().CommandExecuter.ExecuteCommand(cmd);
    }

    void ShowData(){
        var repo = new Repository();
        var measures = repo.Measurements.All();
        //show in ui...?!
    }


    void runSomeCommand(){
        var cmd = MoveMotor(10);
        Global.getInstance().CommandExecuter.ExecuteCommand(cmd);
    }

    void runSomeProcessingCommands(){
        var cmd = ProccessImage(image);
        Global.getInstance().CommandExecuter.ExecuteCommand(cmd);
    }

}