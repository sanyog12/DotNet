namespace CatalaogManager;
using Product;
using ProductManager;


public class CatalaogManager{
    public List<Product> GetAllProducts(){

    List<Product> allProducts = new List<Product>();
    allProducts = DBManager.GetAllProducts();
    return allProducts;

    }

    public Product GetProduct(int id){

        List<Product> allProducts = GetAllProducts();
        Product product = allProducts.Find((product)=>product.Id == id);
        return product;
        
    }

}