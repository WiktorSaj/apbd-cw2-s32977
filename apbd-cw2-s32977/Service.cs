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

    public void ReturnEquipment(Rental rental, DateTime realEnd)
    {
        if (rental.realEnd != null)
        {
            Console.WriteLine("Sprzęt był już wcześniej oddany");
            return;
        }
        
        rental.realEnd = realEnd;
        rental.sprzet.available = true;


        if (rental.expectedEnd >= realEnd)
        {
            rental.penalty = 0;
        }
        else
        {
            int late = (realEnd - rental.expectedEnd).Days;
            rental.penalty = late * 2 * rental.sprzet.pricePerDay;
        }
        
        Console.WriteLine("Odnotowano zwrot");
        
    }



    public void AllEquipment()
    {
        foreach (Sprzet sprzet in dataBase.sprzet)
        {
         Console.WriteLine("Sprzęt: " + sprzet.name + " Cena za dzień: "+ sprzet.pricePerDay + " Status: " + sprzet.available);   
        }
    }


    public void AvailableEquipment()
    {
        foreach (Sprzet sprzet in dataBase.sprzet)
        {
            if (sprzet.available)
            {
                Console.WriteLine("Sprzęt: " + sprzet.name + " Cena za dzień: " + sprzet.pricePerDay);
            }
        }
    }


    public void MarkUnavailableEquipment(Sprzet sprzet)
    {
        if (sprzet.available)
        {
            sprzet.available = false;
            Console.WriteLine("Sprzęt oznaczono jako niedostępny");
        }
        else
        {
            Console.WriteLine("Sprzęt jest już niedostępny");
        }
            
    }


    public void ShowLateRentals()
    {
        foreach (Rental rental in dataBase.rentals)
            if (rental.realEnd != null && DateTime.Now > rental.expectedEnd)
            {
                Console.WriteLine("Użytkownik: " + rental.user.surname + " Sprzęt: " + rental.sprzet.name+ " Termin: " + rental.expectedEnd);
            }
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