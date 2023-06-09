class Device {

    public Config Config { get; }
    public string Name { get; set; } 
    public bool Simulated { get; set; }
    public void Initialize(){
        // read config form deviceName
        this.Config = new Config(Name);
        
        if (this.Config.getBool("Simulated"))
            this.Simulated = true;

    }


}