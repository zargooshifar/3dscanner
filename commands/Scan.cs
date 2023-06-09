public class Scan : Command {

    public Scan()
    {
    }

    public override void onExecute(Scanner scanner, Logger logger, CommandExecuter executer)
    {
        int imagesToTake = scanner.Config.getInt("ImagesPerRevelotion");
        int stepPerRev = scanner.Motor.Config.getInt("StepPerRev"); 
        int steps = stepPerRev / imagesToTake;
        
        double weight = scanner.Scale.Measure();

        for (int i = 0; i< imagesToTake; i++){
            
            
            executer.ExecuteCommandBlocking(new TurnLaser(true));
            
            var capture1 = new CaptureImage(Camera1);
            executer.ExecuteCommandBlocking(capture1);

            var capture2 = new CaptureImage(Camera2);
            executer.ExecuteCommandBlocking(capture2);
            
            executer.ExecuteCommandBlocking(new TurnLaser(false));

            executer.ExecuteCommand(new ProccessLaserImage(capture1.Image, capture2.Image));

            //repeat above commands for led light...


            executer.ExecuteCommandBlocking(new MoveMotor(steps));

        }

        //calculate volume...
        var volume = CalculateVolume();
        
        var measure = new Measurement(){ 
            CreatedAt = DateTime.Now(),
            Density = volume/weight,
            Volume = volume,
            Weight = weight
        };

        //save the results
        Repository rep = new Repository();
        rep.Measurements.Add(measure);
        rep.Measurements.SaveChanges();
        

    }

    double CalculateVolume(){
        //...
    }
}