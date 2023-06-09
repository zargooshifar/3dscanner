public class LineLaser : GPIODevice {

    const byte TURN_ON = 0x01;
    const byte TURN_OFF = 0x00;

    public LineLaser(){
        this.Name = "GPIODevice";
    }

    public void Initialize(){
        base.Initialize();
        this.DeviceAddress = Config.getByte("Address");

    }

    public void TurnOn(){
        this.Write(TURN_ON);
    }

    public void TurnOff(){
        this.Write(TURN_OFF);
    }



    
}