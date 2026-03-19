namespace  Projekt;

using System.Text.Json;

public class Program
{
    // Listy
    static public List<User> Users = new List<User>();
    static public List<Due> Dues = new List<Due>();
    static public List<Equipment> Equipments = new List<Equipment>();
    static public List<Lease> Leases = new List<Lease>(); 
    
    
    static void Main(String[] args)
    {
        loadLists();
        Console.WriteLine("Start of the program.");
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    // Wczytywanie List
    private static void loadLists()
    {
        string users = GetPath("users.json");
        string dues = GetPath("dues.json");
        string equipments = GetPath("equipments.json");
        string leases = GetPath("leases.json");
        
        EnsureFile(users);
        EnsureFile(dues);
        EnsureFile(equipments);
        EnsureFile(leases);
        
        Users = JsonSerializer.Deserialize<List<User>>(File.ReadAllText(users)) ?? new List<User>();
        Dues = JsonSerializer.Deserialize<List<Due>>(File.ReadAllText(dues)) ?? new List<Due>();
        Equipments = JsonSerializer.Deserialize<List<Equipment>>(File.ReadAllText(equipments)) ?? new List<Equipment>();
        Leases = JsonSerializer.Deserialize<List<Lease>>(File.ReadAllText(leases)) ?? new List<Lease>();
    }
    
    // Zapisywanie List
    private static void saveLists()
    {
        string users = GetPath("users.json");
        string dues = GetPath("dues.json");
        string equipments = GetPath("equipments.json");
        string leases = GetPath("leases.json");
        
        EnsureFile(users);
        EnsureFile(dues);
        EnsureFile(equipments);
        EnsureFile(leases);
        
        File.WriteAllText(users, JsonSerializer.Serialize(Users));
        File.WriteAllText(dues, JsonSerializer.Serialize(Dues));
        File.WriteAllText(equipments, JsonSerializer.Serialize(Equipments));
        File.WriteAllText(leases, JsonSerializer.Serialize(Leases));
    }
    // Pobieranie ścieżki
    private static string GetPath(string file)
    {
        return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, file);
    }


    // Tworzenie brakujących plików
    private static void EnsureFile(string path)
    {
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "[]"); // pusta lista JSON
        }
    }

}