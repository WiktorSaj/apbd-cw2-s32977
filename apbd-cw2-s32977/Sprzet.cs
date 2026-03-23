namespace apbd_cw2_s32977;

public abstract class Sprzet
{
    private int id {get; set;}
    private bool available {get; set;}
    private String name {get; set;}
    
    private double pricePerDay {get; set;}

    public Sprzet(int id, bool available, String name, double pricePerDay)
    {
        this.id = id;
        this.available = available;
        this.name = name;
        this.pricePerDay = pricePerDay;
    }
}