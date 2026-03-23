namespace apbd_cw2_s32977;

public class Camera:Sprzet
{
    private int iso;
    private double aperture;
    
    public Camera(int id, bool available, String name, double pricePerDay, int iso, double aperture) : base(id,
        available, name, pricePerDay)
    {
        this.iso = iso;
        this.aperture =  aperture;
    }
    
}