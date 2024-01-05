// namespace DAL;
// using BOL;
// using MySql.Data.MySqlClient;
// public static class DBManager
// {
//     public static string coString = "server=192.168.10.150; port=3306; user=dac24; password=welcome; database=dac24";

//     public static List<Employee> GetAll()
//     {
//         List<Employee> list = new List<Employee>();
//         MySqlConnection con = new MySqlConnection();
//         con.ConnectionString = coString;
//         string query = "select * from TimesheetMGM;";
//         try
//         {
//             con.Open();
//             MySqlCommand command = new MySqlCommand(query, con);
//             MySqlDataReader reader = command.ExecuteReader();
//             while (reader.Read())
//             {
//                 int id = int.Parse(reader["id"].ToString());
//                 string Dates = reader["date"].ToString();
//                 string WorkDesc = reader["workdesc"].ToString();
//                 int Duration = int.Parse(reader["duration"].ToString());
//                 string Status = reader["status"].ToString();
//                 Employee emp = new Employee(id, Dates, WorkDesc, Duration, Status);
//                 list.Add(emp);
//             }
//         }
//         catch (Exception e)
//         {
//             Console.WriteLine("in GetAll");
//         }
//         finally
//         {
//             con.Close();
//         }
//         return list;
//     }

// }
namespace DAL;
using BOL;
using MySql.Data.MySqlClient;
public class DBManager
{
    public static string coString = "server=192.168.10.150; port=3306; user=dac24; password=welcome; database=dac24";
    public static List<Employee> GetData()
    {
        List<Employee> plist = new List<Employee>();

        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString = coString;
        string query = "select * from TimesheetMGM";
        MySqlCommand command = new MySqlCommand(query, connection);


        try
        {
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = int.Parse(reader["id"].ToString());
                string Dates = reader["date"].ToString();
                string WorkDesc = reader["workdesc"].ToString();
                int Duration = int.Parse(reader["duration"].ToString());
                string Status = reader["status"].ToString();

                plist.Add(new Employee(id, Dates, WorkDesc, Duration, Status));
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            connection.Close();
        }


        return plist;
    }
    public static bool insertAll(int id, string date, string workdesc, int duration, string status)
    {
        bool status1 = false;

        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString = coString;
        string query = "insert into TimesheetMGM values(@id, @date, @workdesc , @duration,@status;)";
        MySqlCommand command = new MySqlCommand(query, connection);
        try
        {
            connection.Open();
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@workdesc", workdesc);
            command.Parameters.AddWithValue("@duration", duration);
            command.Parameters.AddWithValue("@status", status);
            command.ExecuteNonQuery();
            status1 = true;
        }
        catch (Exception e)
        {
            Console.WriteLine("in insert all");
        }
        finally
        {
            connection.Close();
        }
        return status1;
    }

}