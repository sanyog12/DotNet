using BOL;
using MySql.Data.MySqlClient;
namespace DAL.Connected;
//using inbuilt, external Object Models


public class DBManager{

    public static string conString=@"server=192.168.10.150;port=3306;user=dac24; password=welcome;database=dac24;";
    
    //Employee Operations CRUD

    public static bool Insert(Product prod){
        bool status = false;
        string query = "INSERT INTO product(product_id,name,quantity)"+"VALUES('"+ prod.Product_id +"','"+ prod.Name +"','"+prod.Quantity+"')";

        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        try{
            con.Open();
            MySqlCommand  command = new MySqlCommand(query,con);
            command.ExecuteNonQuery();
            status = true;

        }catch(Exception e){
            Console.WriteLine("failed");
        }
        finally{
            con.Close();
        }
        return status;
    }
    
    public static bool Update(Product prod){
        bool status = false;
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        string query = "UPDATE product SET name = 'YEA' where product_id = 2";
        try{
            con.Open();
            MySqlCommand command = new MySqlCommand(query,con);
            command.ExecuteNonQuery();
            status = true;
        }
        catch(Exception e){
            Console.WriteLine("wrong");
        }
        finally{
            con.Close();
        }
        return status;
    }

    public static bool Delete(Product prod){
        Boolean status = false;
        MySqlConnection con = new MySqlConnection();
        string query = "DELETE FROM products WHERE product_id=1";
        con.ConnectionString=conString;
        try{
            con.Open();
            MySqlCommand command = new MySqlCommand(query,con);
            command.ExecuteNonQuery();
            status = true;

        }
        catch(Exception e){
            Console.WriteLine("error while deleting");
        }
        finally{
            con.Close();
        }
        return status;
    }

    public static bool Update(Department dept)
    {
        bool status = false;
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        try
        {
            string query = "UPDATE departments SET location='" + dept.Location + "', name='" + dept.Name + "' WHERE id=" + dept.Id;
            MySqlCommand command = new MySqlCommand(query, con);
            con.Open();
            command.ExecuteNonQuery();
            status = true;
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            con.Close();
        }
        return status;
    }
    public static bool Delete(int id){
        bool status=false;
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        try
        {
            string query = "DELETE FROM departments WHERE id=" + id;
            MySqlCommand command = new MySqlCommand(query, con);
            con.Open();
            command.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            con.Close();
        }
      return status;
    }

   
  
  public static bool Update(Department dept)
    {
        bool status = false;
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        try
        {
            string query = "UPDATE departments SET location='" + dept.Location + "', name='" + dept.Name + "' WHERE id=" + dept.Id;
            MySqlCommand command = new MySqlCommand(query, con);
            con.Open();
            command.ExecuteNonQuery();
            status = true;
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            con.Close();
        }
        return status;
    }



    public static List<Product> GetAllProducts(){
       List<Product> list=new List<Product>();
        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString ="server=localhost;port=3306;user=root;password=password;database=ecommerce";
        string query ="select * from products";
        MySqlCommand command = new MySqlCommand(query, connection);
        try{
            connection.Open();
            MySqlDataReader reader=command.ExecuteReader();
            
            while(reader.Read()){
            Product product=new Product();
            int id=int.Parse(reader["product_id"].ToString());
            string title=reader["product_title"].ToString();
            string description=reader["description"].ToString();
            product.Id=id;
            product.Title=title;
            product.Description=description;
            list.Add(product);
            }
            reader.Close();
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            connection.Close();
        }
       
       
      
        return list;
    }

    
    }

    






//

            //DisConnected Data Access Mode
             //MySqlConnection  : establishing connection
            //MySqlCommand      : query execution
           //MySqlDataApater
            //DataSet
            //DataTable
            //DataRow
            //DataColumn
            //DataRealtion
