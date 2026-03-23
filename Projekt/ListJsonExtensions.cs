using System.Text.Json;

namespace Projekt;

public static class ListJsonExtensions
{
    public static List<T> LoadListFromFile<T>(string path)
    {
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "[]");
            return [];
        }

        var json = File.ReadAllText(path);
        
        return JsonSerializer.Deserialize<List<T>>(json) ?? [];// Jak coś pójdzie źle daje pustą listę
    }

    public static void WriteListToFile<T>(this List<T> items, string path)
    {
        File.WriteAllText(path, JsonSerializer.Serialize(items, new JsonSerializerOptions { WriteIndented = true }));
    }
}