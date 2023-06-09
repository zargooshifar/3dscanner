class Motor: SerialDevice {

    public Motor(){
        this.Name = "Motor";
    }

    void Initialize(){
        base.Initialize();
        this.BaudRate = this.Config.getInt("BaudRate");
        
        Home();
    }
    public void Home();
    public void SetVelosity(int value);
    public void MoveAbsolute(int distance);
    public void MoveIncremental(int distance);
    public int GetPosition();

}