class GPIODevice: Device {
    
    public int DeviceAddress { get; set; }
    GPIODevice(){
        this.Name = "GPIODevice";

    }

    void Initialize(){
        base.Initialize();
    }

    public void Write(byte[] data){
        //write data to device address...
    }
    public byte[] Read(){
        //read from device address
    }

}