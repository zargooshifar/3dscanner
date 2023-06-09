public class Logger {

    enum LogLevel {
        DEBUG,
        WARNING,
        ERROR
    }

    public LogLevel LogLevel { get; set; }
    
    public Logger(string path){
        //open a file as path for writing logs
    }

    public void Write(string message, LogLevel level){
        if(level <= LogLevel){
            //write log to file...
        }
    }

}