namespace Projekt;

public class User
{
    public Guid Id { get; }
    public string Name { get; }
    public string Surname { get; }
    public User(string name, string surname)
    {
        Id = Guid.NewGuid();
        Name = name;
        Surname = surname;
    }
}