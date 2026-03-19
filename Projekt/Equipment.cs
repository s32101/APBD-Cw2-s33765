namespace Projekt;

public class Equipment
{
    public Guid Id { get; }
    public bool Availibility { get; set; }

    public Equipment()
    {
        Id = Guid.NewGuid();
        Availibility = true;
    }
}