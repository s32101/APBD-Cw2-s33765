namespace Projekt;

public class Lease
{
    private int TimeToReturn = 14; // W dniach
    public Equipment equipment { get; }
    DateTime LeaseDate;
    DateTime ExpiryDate;
    
    DateTime ReturnDate;
    
    Lease(Equipment equipment)
    {
        this.equipment = equipment;
        this.equipment.Availibility = false;
        LeaseDate = DateTime.Now;
        ExpiryDate = LeaseDate.AddDays(TimeToReturn);
    }


    public void Return()
    {
        ReturnDate = DateTime.Now;
        this.equipment.Availibility = true;
        if (ReturnDate > ExpiryDate)
        {
            calculateCosts();
        }
        
    }

    int calculateCosts()// opłata = 20 złotych za każdy dzień opóźnienia
    {
        TimeSpan timeSpan = ExpiryDate - ReturnDate;
        int costs = 20 * timeSpan.Days;
        return costs;
    }
    
}