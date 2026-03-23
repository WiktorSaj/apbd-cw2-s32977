namespace apbd_cw2_s32977;

public class Rental
{
    public User user{ get; set; }
    public Sprzet sprzet{ get; set; }
    public DateTime start{ get; set; }
    public DateTime expectedEnd{ get; set; }
    public DateTime? realEnd{ get; set; }

    public Rental(User user, Sprzet sprzet, DateTime start, DateTime expectedEnd)
    {
        this.user = user;
        this.sprzet = sprzet;
        this.start = start;
        this.expectedEnd = expectedEnd;
        this.realEnd = null;
    }
    
}