public class SerialDevice() : Device{

    public int BaudRate { get; set; }
    
    void Open();
    string Read();
    void Write(string data);
    void Callback();
}