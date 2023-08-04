using Core.Domain.User;
using Core.Interface.Product;
using Infrastructure.Data.Context;
using Infrastructure.Data.Entities.Product;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Repository;
using AutoMapper;

namespace Infrastructure.Repository.Product;

public class Product : IProduct
{

    private readonly Context dbContext;
    private readonly IMapper productMapping;

    public Product(Context _dbContext, IMapper mapper)
    {
        dbContext = _dbContext;
        productMapping = mapper;
    }
    public void AddProduct(MProduct product)
    {
        //var tblProduct = new TblProduct();
        //tblProduct.ProductName = product.ProductName;
        //tblProduct.Category = product.Category;
        //tblProduct.Price = product.Price;
        //tblProduct.SubmitDate = product.SubmitDate.PersianDateToMiladiDate();
        TblProduct tblProduct=productMapping.Map<TblProduct>(product);

        dbContext.TblProducts.Add(tblProduct);
        dbContext.SaveChanges();

    }

    public void DeleteProduct(int id)
    {
        var Product = dbContext.TblProducts.Find(id);
        dbContext.TblProducts.Remove(Product);
        dbContext.SaveChanges();
    }

    public List<MProduct> GetAllProduct()
    {
        var products = dbContext.TblProducts.ToList();
        List<MProduct> mProducts= productMapping.Map<List<MProduct>>(products);
        //var mProducts = new List<MProduct>();
        //foreach (var product in products)
        //{
            //MProduct mProduct = new MProduct();
            //mProduct.ProductID = product.ProductID;
            //mProduct.ProductName = product.ProductName;
            //mProduct.Category = product.Category;
            //mProduct.Price = product.Price;
            //mProduct.SubmitDate = product.SubmitDate.ConvertToJalali();
            //mProducts.Add(mProduct);
        //}
        return mProducts;
    }

    public MProduct GetProductById(int id)
    {
        var product = dbContext.TblProducts.Find(id);
        var mProduct= productMapping.Map<MProduct>(product);
        //var mProduct = new MProduct();
        //mProduct.ProductName = product.ProductName;
        //mProduct.Category = product.Category;
        //mProduct.Price = product.Price;
        //mProduct.ProductID = product.ProductID;
        //mProduct.SubmitDate = product.SubmitDate.ConvertToJalali();
        return mProduct;
    }

    public List<MProduct> GetProductInRange(int[] productIds)
    {
        var tblProducts = new List<TblProduct>();
        var mProducts = new List<MProduct>();
        for (int i = 0; i < productIds.Length; i++)
        {
            var product = dbContext.TblProducts.Find(productIds[i]);
            tblProducts.Add(product);
        }
        
         mProducts=productMapping.Map<List<MProduct>>(tblProducts);

        //foreach (var product in tblProducts)
        //{
            //MProduct mProduct = new MProduct();
            //mProduct.ProductID = product.ProductID;
            //mProduct.ProductName = product.ProductName;
            //mProduct.Category = product.Category;
            //mProduct.Price = product.Price;
            //mProduct.SubmitDate = product.SubmitDate.ConvertToJalali();
            //mProducts.Add(mProduct);
        //}
        return mProducts;
    }

    public void UpdateProduct(MProduct product)
    {
        var tblProduct = dbContext.TblProducts.Find(product.ProductID);
        tblProduct=productMapping.Map<TblProduct>(product);
        //tblProduct.ProductName = product.ProductName;
        //tblProduct.Category = product.Category;
        //tblProduct.Price = product.Price;
        //tblProduct.ProductID = product.ProductID;
        //tblProduct.SubmitDate = product.SubmitDate.PersianDateToMiladiDate();
        dbContext.SaveChanges();
    }
}