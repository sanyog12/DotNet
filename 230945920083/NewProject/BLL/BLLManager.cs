namespace BLL;
using BOL;
using DAL;
public class BLLManager
{
    // public List<Employee> GetAllData()
    // {

    //     List<Employee> list = new List<Employee>();
    //     list= DBManager.GetAll();
    //     return list;
    // }
    public static List<Employee> GetAllData()
    {
        List<Employee> plist = DBManager.GetData();
        return plist;
    }

    public static bool insertAllData(int id, string date, string workdesc, int duration, string status){
    bool stat = DBManager.insertAll(id, date, workdesc, duration, status);
    return stat;
    }
}
