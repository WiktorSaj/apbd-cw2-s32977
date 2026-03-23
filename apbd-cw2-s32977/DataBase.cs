namespace apbd_cw2_s32977;

public class DataBase
{
    public List<User> users = new List<User>();
    public List<Sprzet> sprzet = new List<Sprzet>();
    public List<Rental> rentals = new List<Rental>();
    
    public List<User> getUsers()
    {
        return users;
    }

    public List<Sprzet> getSprzet()
    {
        return sprzet;
    }

    public List<Rental> getRentals()
    {
        return rentals;
    }
    
    public void addUser(User user)
    {
        users.Add(user);
    }

    public void addSprzet(Sprzet sprzetItem)
    {
        sprzet.Add(sprzetItem);
    }

    public void addRental(Rental rental)
    {
        rentals.Add(rental);
    }

}
    