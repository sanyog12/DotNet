namespace BOL;
public class Product
{

    private int product_id;
    private string name;
    
    private int quantity;
    // private string category;
    // private string description;
    // private float unitPrice;
    // private int balance;
    // private string paymentTerm;
    // private string delivery;


    public Product(){
    }

   

    public Product(int productId, string title, int brand, int category){
        this.product_id = productId;
        this.name = title;       
        this.quantity = category;
    }

    

    //Properties of Product Entity

    public int Product_id{
        get { return product_id; }
        set { product_id = value; }
    }
    
    public string Name{
            get { return name; }
            set { name = value; }
    }


    public int Quantity{
        get { return quantity; }
        set { quantity = value; }
    }
      
}
