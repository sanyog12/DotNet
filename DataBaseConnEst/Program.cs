using System.Data;
using MySql.Data.MySqlClient;

MySqlConnection conn = new MySqlConnection();
conn.ConnectionString = "server=192.168.10.150;port=3306;user=dac24;password=welcome;database=dac24;";
Console.WriteLine("enter the number u want to update");
// int id = int.Parse(Console.ReadLine());
// string query = "update product set quantity = 99 where quantity = 100";

//MySqlCommand  command = new MySqlCommand(query,conn);
string query = "select * from product";
MySqlCommand command = new MySqlCommand(query,conn);
try{
     conn.Open();

    // MySqlDataReader reader = command.ExecuteReader();

    // while(reader.Read()){
    //     int id = int.Parse(reader["product_id"].ToString());
    //     string name = reader["name"].ToString();
    //     int qty = int.Parse(reader["quantity"].ToString());
    //     Console.WriteLine(id+" "+name+" "+qty);
    // }
    // command.ExecuteNonQuery();
    int count = int.Parse((command.ExecuteScalar()).ToString());
    Console.WriteLine("No of products available are "+count);

}catch(Exception e){
    Console.WriteLine(e.Message);
}
finally{
    conn.Close();
}
