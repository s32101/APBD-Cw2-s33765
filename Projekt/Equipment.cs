namespace Projekt;

public class Equipment
{
    public Guid Id { get; }
    public bool Availibility { get; set; }
    public string Name { get; set; }

    Equipment(String name)
    {
        Id = Guid.NewGuid();
        Availibility = true;
        Name = name;
    }
}