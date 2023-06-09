//using Entity Framework to store data...
public class Repository: DBContext{

    public DbSet<Measurement> Measurements { get; set; }
    public Repository(){}
    
}