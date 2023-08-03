


using Core.Domain.User;

namespace Core.Interface.Product;
public interface IProduct
{
      //Create
      void AddProduct(MProduct product);
      
      //Read
      List<MProduct> GetAllProduct();

      //Update
      void UpdateProduct(MProduct product);

      //Delete
      void DeleteProduct(int id);

      //GetById
      MProduct GetProductById(int id);

      //GetInRange
      List<MProduct> GetProductInRange(int[] productIds);
 
}