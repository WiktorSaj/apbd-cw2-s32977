namespace apbd_cw2_s32977;

public class Rental
{
    private User user;
    private Sprzet sprzet;
    private DateTime start;
    private DateTime expectedEnd;
    private DateTime? realEnd;

    public Rental(User user, Sprzet sprzet, DateTime start, DateTime expectedEnd)
    {
        this.user = user;
        this.sprzet = sprzet;
        this.start = start;
        this.expectedEnd = expectedEnd;
        this.realEnd = null;
    }
    
}