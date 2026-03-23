namespace apbd_cw2_s32977;

public class Projector: Sprzet
{
    private int lumens;
    private string resolution;

    public Projector(int id, bool available, String name, double pricePerDay, int lumens, string resolution) : base(id,
        available, name, pricePerDay)
    {
        this.lumens = lumens;
        this.resolution =  resolution;
    }
}