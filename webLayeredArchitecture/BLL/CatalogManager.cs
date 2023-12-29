namespace BLL;
using BOL;
using DAL;

public class CatalogManager{
    public List<Product> GetAllProducts(){
        List<Product> allProducts = new List<Product>();
        allProducts = DBManager.GetAllProducts();
        return allProducts;
    }

    public Product GetProduct(int id){
        List<Product> allProducts =GetAllProducts();
        Product product = allProducts.Find((product)=>product.Id == id);
        return product;
    }
}