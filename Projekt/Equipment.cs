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

    public override string ToString()
    {
        return $"Equipment: {Id}: Availible: {Availibility}";
    }
}