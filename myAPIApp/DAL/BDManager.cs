// using HRPortal.Models;
using Model;
using MySql.Data.MySqlClient;
namespace DAL;
// public static class HRDBManager{

//     public static  List<Employee> GetAllEmployees(){
//         List<Employee> employees=new List<Employee>();
//         employees.Add(new Employee{Id=23,Name="SachinTendulkar"});
//         employees.Add(new Employee{Id=24,Name="SunilGavaskar"});
//         employees.Add(new Employee{Id=56, Name="SachinPatil"});
//         employees.Add(new Employee{Id=33,Name="JeevanSharma"});
//         employees.Add(new Employee{Id=99,Name="RajKumar"});
//         return employees;
//     }
// }
public class DBManager{
public static string coString = @"server=localhost;port=3306;user=root;password=1233@;database=employee;";

public static bool Register(String email, String password){
    bool status = false;
MySqlConnection con = new MySqlConnection();
    con = coString;
    String query = @"INSERT INTO emp values (@email,@password);";
    try{
        con.Open();
        MySqlCommand command =new MySqlCommand(query,con);
        command.Parameters.AddWithValue("@email",email);
        command.Parameters.AddWithValue("@password",password);
        command.ExecuteNonQuery();
        status = true;
        }catch(Exception e){
        Console.WriteLine("in the regisert");
    }
    finally{
        con.Close();
    }

    return status;
}
public static bool DeleteEmp(String Email){
    bool status = false;
    MySqlConnection con = new MySqlConnection();
    con.ConnectionString = coString;
    try{
        String query = @"DELETE FROM emp WHERE email = @email";
        MySqlCommand command = new MySqlCommand(query,con);
        con.Open();
         command.Parameters.AddWithValue("@email",Email); 
         command.ExecuteNonQuery();
         status = true;     

    }catch(Exception e){
        Console.WriteLine("Error in DeleteEmp");
    }
    finally{
        con.Close();
    }
    return status;
}
public static List<Employee> AllEmp(){
    List<Employee> list = new List<Employee>();
    MySqlConnection con = new MySqlConnection();
    con = coString;
    String query = @"SELECT * FORM emp;";
    try{
        con.Open();
        MySqlCommand command =new MySqlCommand(query,con);
        MySqlReader reader = command.ExecuteReader();

        while(reader.Read()){
            string email = reader["email"].ToString();
            string password = reader["password"].ToString();
            Employee emp = new Employee{Email = email,Password = password};
            list.Add(emp);
        }
    }catch(Exception e){
        Console.WriteLine("error in AllEmp");
    }
    finally{
        con.Close();
    }
    return list;
}


}