public class PylonCamera: Device {

    public int CamID { get; set; }
    PylonCamera(){

    }

    void Initialize(){
        base.Initialize();
        //read id from config and set CamId
        this.Config.getString("ID");
        this.Open();
    }

    void Open(){
        // open camera by id
    }

    void Capture();
    
    void Live();

}