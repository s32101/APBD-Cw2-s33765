using System.Security.AccessControl;

namespace  Projekt;

using System.Text.Json;

public class Program
{
    // Repozytoria
    static List<User> Users;
    static List<Due> Dues;
    static List<Equipment> Equipments;
    static List<Lease> Leases;
    
    // bool podtrzymujący program przy życiu
    static bool isRunning = true;
    
    static void Main(String[] args)
    {
        LoadDatabase();

        StartProgram();

    }

    private static void StartProgram()
    {
        while (isRunning)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            
            string[] inputArgs = input.Split(' ');
            string command = inputArgs[0];

            switch (command)
            {
                case "exit":
                    isRunning = false;
                    break;
                case "help":
                    Console.WriteLine("Here will be listed all availible commands");
                    break;
                default:
                    Console.WriteLine($"'{input}' is not recognized as an available command");
                    break;
                    
            }
        }
    }

    private static void LoadDatabase()
    {
        string basePath = AppDomain.CurrentDomain.BaseDirectory;

        Users = ListJsonExtensions.LoadListFromFile<User>(GetPath("users.json"));
        Dues = ListJsonExtensions.LoadListFromFile<Due>(GetPath("dues.json"));
        Equipments = ListJsonExtensions.LoadListFromFile<Equipment>(GetPath("equipments.json"));
        Leases = ListJsonExtensions.LoadListFromFile<Lease>(GetPath("leases.json"));
        
        Console.WriteLine("Database Loaded");
    }
    
    
    
    // Wyświetlanie całej listy (Trzeba dodać do każdej głównej klasy ovveride na String)
    public static void PrintList<T>(List<T> list)
    {
        foreach (T item in list)
        {
            Console.WriteLine(item);
        }
    }
    
    // Pobieranie ścieżki
    private static string GetPath(string file)
    {
        return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, file);
    }

}