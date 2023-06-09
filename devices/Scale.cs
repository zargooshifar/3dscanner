   public class Scale : SerialDevice {

    public Scale(){
        this.Name = "Scale";
    }

    void Initialize(){
        base.Initialize();
        this.BaudRate = this.Config.getInt("BaudRate");
        
    }
    public void SetToZero();
    public double Measure();

}