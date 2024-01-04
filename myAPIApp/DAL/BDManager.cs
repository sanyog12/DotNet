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
public static string coString = "server=192.168.10.150;port=3306;user=dac24;password=welcome;database=dac24;";

public static bool Register(String email, String password){
    bool status = false;
MySqlConnection con = new MySqlConnection();
    con.ConnectionString = coString;
    
    try{
        String query = "INSERT INTO empp  values (@email,@password);";
         MySqlCommand command =new MySqlCommand(query,con);
        con.Open();
        command.Parameters.AddWithValue("@email",email);
        command.Parameters.AddWithValue("@password",password);
         command.ExecuteNonQuery();
        status = true;
        }catch(Exception e){
        Console.WriteLine(e.Message);
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
        String query = @"DELETE FROM empp WHERE email = @email";
        MySqlCommand command = new MySqlCommand(query,con);
        con.Open();
         command.Parameters.AddWithValue("@email",Email); 
         command.ExecuteNonQuery();
         status = true;     

    }catch(Exception e){
      Console.WriteLine(e.Message);
    }
    finally{
        con.Close();
    }
    return status;
}
public static List<Employee> AllEmp(){
    List<Employee> list = new List<Employee>();
    MySqlConnection con = new MySqlConnection();
    con.ConnectionString = coString;
    String query = @"SELECT * FroM empp;";
    try{
        con.Open();
        MySqlCommand command =new MySqlCommand(query,con);
        
        MySqlDataReader reader = command.ExecuteReader();

        while(reader.Read()){
            string email = reader["email"].ToString();
            string password = reader["password"].ToString();
            Employee emp = new Employee{Email = email,Password = password};
            list.Add(emp);
          
        }
    }catch(Exception e){
       Console.WriteLine(e.Message);
    }
    finally{
        con.Close();
    }
    return list;
}

public static int LogIn(String Email,String Password){
    int ttl = 0;
    String query = @"select count(*) from empp where email = @Email and password = @Password";
    MySqlConnection con = new MySqlConnection();
    con.ConnectionString = coString;
    try{
        con.Open();
        MySqlCommand command = new MySqlCommand(query,con); 
        command.Parameters.AddWithValue("@Email",Email);
        command.Parameters.AddWithValue("@Password",Password);
        ttl = Convert.ToInt32(command.ExecuteScalar());

        if(ttl>0){
            return ttl;
        }

    }catch(Exception e){
            Console.WriteLine(e.Message);
    }
    finally{
        con.Close();
    }
    return ttl;
}


}