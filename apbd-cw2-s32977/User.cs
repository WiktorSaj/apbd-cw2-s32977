namespace apbd_cw2_s32977;

public abstract class User
{
    private int id { get; set; }
    
    private string name { get; set; }
    
    private string surname { get; set; }
    
    public User(int id, string name, string surname)
    {
        this.id = id;
        this.name = name;
        this.surname = surname;
    }
}