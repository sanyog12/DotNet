namespace BLL;
using BOL;
using DAL.Connected;
public class HRManager{
    public List<Product> GetAllDepartments(){
        List<Product> allDepartments = new List<Product>();
        allDepartments = DBManager.GetAllProducts();
        return allDepartments;
    }
}