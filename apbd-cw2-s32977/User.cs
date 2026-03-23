namespace apbd_cw2_s32977;

public abstract class User
{
    public int id { get; set; }
    
    public string name { get; set; }
    
    public string surname { get; set; }
    
    public User(int id, string name, string surname)
    {
        this.id = id;
        this.name = name;
        this.surname = surname;
    }
}