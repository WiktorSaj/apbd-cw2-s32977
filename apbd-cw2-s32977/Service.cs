using System.Security.AccessControl;

namespace apbd_cw2_s32977;

public class Service
{
    public DataBase dataBase{ get; set; }
    
    public Service(DataBase dataBase)
    {
        this.dataBase = dataBase;
    }

    public void RentEquipment(User user, Sprzet sprzet, DateTime start, DateTime expectedEnd)
    {

        if (!sprzet.available)
        {
            Console.WriteLine("Sprzęt niedostępny");
            return;
        }

        if (CountRentsForUser(user) >= Limit(user))
        {
            Console.WriteLine("Osiągnięto limit wypożyczeń");
            return;
        }
        
        
        dataBase.addRental(new Rental(user, sprzet, start, expectedEnd));
        sprzet.available = false;
        
        Console.WriteLine("Zapisano wypożyczenie");
        
    }
    





    public int Limit(User user)
    {
        if (user is Student) 
        {
            return 2;
        }
        else
        {
            return 5;
        }
    }

    public int CountRentsForUser(User user)
    {
        int count = 0;

        foreach (Rental rental in dataBase.rentals)
        {
            if (user == rental.user && rental.realEnd == null)
                count++;
        }
        
        return count;

    }

    

}