namespace DAL;
using BOL;
using MySql.Data.Client;
public static class DBManager
{
    public static string coStirng = "server=localhost; port= 3306; user=root;password=123Sanyog123@; database = dac24";
    public static MySqlConnection con = new MySqlConnection();
    public static List<Student> GetAll()
    {
        con.ConnectingString = coStirng;
        string query = "select * from student";
        List<Student> list = new List<Student>();
        MySqlCommand cmd = new MySqlCommand(query, con);
        try
        {
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                int id = int.Parse((reader["id"]).ToString());
                string name = reader["name"].ToString();
                string email = reader["email"].ToString();
                Student std = new Student(id, name, email);
                list.Add(std);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Msg);
        }
        finally
        {
            con.Close();
        }
        return list;
    }

}
