using Core.Domain.User;
using Core.Interface.Product;
using Infrastructure.Data.Context;
using Infrastructure.Data.Entities.Product;

namespace Infrastructure.Repository.Product;

public class Product : IProduct
{

    private readonly Context  dbContext;

    public Product(Context _dbContext)
    {
        dbContext=_dbContext;
    }
    public void AddProduct(MProduct product)
    {
        var tblProduct=new TblProduct();
        tblProduct.ProductName = product.ProductName;
        tblProduct.Category=product.Category;
        tblProduct.Price=product.Price;
        dbContext.TblProducts.Add(tblProduct);
        dbContext.SaveChanges();

    }

    public void DeleteProduct(int id)
    {
        var Product=dbContext.TblProducts.Find(id);
        dbContext.TblProducts.Remove(Product);
        dbContext.SaveChanges();
    }

    public List<MProduct> GetAllProduct()
    {
        var products=dbContext.TblProducts.ToList();
        var mProducts=new List<MProduct>();
        foreach(var product in products)
        {
             MProduct mProduct =new MProduct();
             mProduct.ProductID=product.ProductID;
             mProduct.ProductName = product.ProductName; 
             mProduct.Category=product.Category;
             mProduct.Price=product.Price;
             mProducts.Add(mProduct);
        }
        return mProducts;
    }

    public MProduct GetProductById(int id)
    {
        var product=dbContext.TblProducts.Find(id);
        var mProduct=new MProduct();
        mProduct.ProductName=product.ProductName;
        mProduct.Category=product.Category;
        mProduct.Price=product.Price;
        mProduct.ProductID=product.ProductID;
        return mProduct;
    }

    public void UpdateProduct(MProduct product)
    {
        var tblProduct=dbContext.TblProducts.Find(product.ProductID);
        tblProduct.ProductName=product.ProductName;
        tblProduct.Category=product.Category;
        tblProduct.Price = product.Price;
        tblProduct.ProductID=product.ProductID;
        dbContext.SaveChanges();
    }
}