namespace apbd_cw2_s32977;

public class Employee:User
{
    private string nrTel { get; set; }

    public Employee(int id, string name, string surname, string nrTel) : base(id, name, surname)
    {
        this.nrTel = nrTel;
    }
}