
public class Config {
    private readonly string deviceName;
    
    
    public Config(string DeviceName){
        deviceName = DeviceName;
        Load();
    }

    void Load(){
        //load device configs from config file and read specified section

    }

    public bool getBool(string propertyName){
        return false;
    }
     public string getString(string propertyName){
        return "somestring";
    }

    public int getInt(string propertyName){
        return 0;
    }

    public byte getByte(string propertyName){
        return 0x00;
    }


}