class CaptureImage: Command {
    private readonly Camera camera;
    public Bitmap Image { get; set; }
    public CaptureImage(Camera camera)
    {
        this.camera = camera;
    }

    public override void onExecute(Scanner scanner, Logger logger, CommandExecuter executer)
    {
        Image = camera.CaptureImage();
    }
}