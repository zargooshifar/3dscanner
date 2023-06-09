public class DoorSensor : GPIODevice {

    const byte GET_DATA = 0x01;
    const byte OPEN = 0x02;
    const byte CLOSE = 0x03;
    
    public DoorSensor(){
        this.Name = "SensorDoor";
    }

    void Initialize(){
        base.Initialize();
        this.DeviceAddress = this.Config.getByte("Address");

    }

    public bool IsOpen(){
        byte data = this.Read();
        if(data == OPEN)
            return true;
        return false;
    }

}