namespace BLL;
using DAL;
using BOL;
public class BLLManager
{
    public List<Student> GetList()
    {
        List<Student> list = DBManager.GetAll();
        return list;
    }

    public bool InsertInto1(int id, string name, string email)
    {
        bool status = DBManager.insertIn(id, name, email);
        return status;
    }

    public bool DeleteById(int id){
        bool status = DBManager.DeleteBy(id);
        return status;
    }

    public bool UpdateById(int id,string name){
    bool status =DBManager.UpdateBy(id,name);
    return status;
    }
}
