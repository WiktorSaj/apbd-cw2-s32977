namespace apbd_cw2_s32977;

public abstract class Sprzet
{
    public int id {get; set;}
    public bool available {get; set;}
    public String name {get; set;}
    
    public double pricePerDay {get; set;}

    public Sprzet(int id, bool available, String name, double pricePerDay)
    {
        this.id = id;
        this.available = available;
        this.name = name;
        this.pricePerDay = pricePerDay;
    }
}