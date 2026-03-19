namespace Projekt;

public class Equipment
{
    public Guid Id { get; }
    public bool Availibility { get; set; }

    Equipment()
    {
        Id = Guid.NewGuid();
        Availibility = true;
        
    }
}