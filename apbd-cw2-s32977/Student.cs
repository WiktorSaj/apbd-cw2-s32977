namespace apbd_cw2_s32977;

public class Student:User
{
    private String sNumber { get; set; }

    public Student(int id, string name, string surname, string sNumber) : base(id, name, surname)
    {
        this.sNumber = sNumber;
    }
}