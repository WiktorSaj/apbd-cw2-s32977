using System.Security.AccessControl;

namespace apbd_cw2_s32977;

public class Service
{
    public DataBase dataBase{ get; set; }
    
    public Service(DataBase dataBase)
    {
        this.dataBase = dataBase;
    }

    

}