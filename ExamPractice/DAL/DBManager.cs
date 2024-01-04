namespace DAL;
using BOL;
using MySql.Data.MySqlClient;

public static class DBManager
{
    public static string coStirng = "server=localhost; port= 3306; user=root;password=123Sanyog123@; database = dac24";
    public static MySqlConnection con = new MySqlConnection();
    public static List<Student> GetAll()
    {
        // con.ConnectionString = coStirng;
        // string query = "select * from student";
        // List<Student> list = new List<Student>();
        // MySqlCommand cmd = new MySqlCommand(query, con);
        // try
        // {
        //     con.Open();
        //     MySqlDataReader reader = cmd.ExecuteReader();
        //     while (reader.Read())
        //     {

        //         int id = int.Parse((reader["id"]).ToString());
        //         string name = reader["name"].ToString();
        //         string email = reader["email"].ToString();
        //         Student std = new Student(id, name, email);
        //         list.Add(std);
        //     }
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine(e.Message);
        // }
        // finally
        // {
        //     con.Close();
        // }
        // return list;
             List<Student> list = new List<Student>();
        string query = "select * from student;";
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = coStirng;
   
        try
        {
            MySqlCommand command = new MySqlCommand(query, con);
                
            con.Open();
             MySqlDataReader reader =  command.ExecuteReader();   
            while (reader.Read())
            {
                int id = int.Parse(reader["id"].ToString());
                string name = reader["name"].ToString();
                string email = reader["email"].ToString();
                Student s = new Student(id,name,email);
                list.Add(s);

            }
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            con.Close();
        }
    return list;

    }
    public static bool insertIn(int id, string name, string email)
    {
        bool status = false;
        string query = "insert into student values(@id,@name,@email);";
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = coStirng;

        try
        {
            con.Open();
            MySqlCommand command = new MySqlCommand(query, con);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@email", email);
            command.ExecuteNonQuery();
            status = true;
        }
        catch (Exception e)
        {
            Console.WriteLine("Sanyog: " + e.Message);
        }
        finally
        {
            con.Close();
        }

        return status;
    }


    public static bool DeleteBy(int id){
        bool status = false;
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = coStirng;
        string query = "delete from student where id = @id;";
        con.ConnectionString = coStirng;
        try{
            MySqlCommand command = new MySqlCommand(query,con);
            con.Open();
            command.Parameters.AddWithValue("@id",id);
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

    public static bool UpdateBy(int id, string name){
        bool status = false;
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = coStirng;
        string query = "update student set name = @name where id = @id;";
        try{
            MySqlCommand command = new MySqlCommand(query,con);
            con.Open();
            command.Parameters.AddWithValue("@id",id);
            command.Parameters.AddWithValue("@name",name);
            command.ExecuteNonQuery();
            status = true;
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }finally{
            con.Close();
        }
        return status;
    }

}
