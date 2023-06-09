public class Scanner : Device{

    public Camera1 Camera1 { get;}
    public Camera2 Camera2 { get;}
    public Motor Motor {get;}
    public Scale Scale  {get;}
    public DoorSensor DoorSensor  {get;}
    public LineLaser LineLaser  {get;}

    public Scanner(){
        this.Name = "Scanner";
        this.Camera1 = new();
        this.Camera2 = new();
        this.Motor = new();
        this.Scale = new();
        this.DoorSensor = new();
        this.LineLaser = new();
    }

    public void Initialize(){
        base.Initialize();
    }


}