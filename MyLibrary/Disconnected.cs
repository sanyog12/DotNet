namespace Disconnected;
using Department;
using System.Data;
using MySql.Data.MySqlClient;

public class DBManager{
    public static string conString=@"server=192.168.10.150;user=dac24;port=3306;password=welcome;database=dac24;";
    public static List<Department> GetAllDepartments(){
        List<Department> allDepartments(){
            List<Department> allDepartmens = new List<Department>();
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = conString;
            try{
                DataSet ds = new DataSet();
                MySqlCommand cmd = new MySqlCommand();
                string query = "SELECT * FROM departments; SELECT * FROM employees; SELECT * FROM roles;";
                cmd.CommandText = query;
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                DataRowCollection rows = dt.Rows;
                foreach(DataRow row in rows){
                    int id = int.Parse
                }
            }
        }
        return allDepartments;
    }   
}