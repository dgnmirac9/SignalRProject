using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concrete;

public class ProductManager:IProductDal
{
    private readonly IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }

    public void Add(Product entity)
    {
        _productDal.Add(entity);
    }

    public void Delete(Product entity)
    {
        _productDal.Delete(entity);
    }

    public void Update(Product entity)
    {
        _productDal.Update(entity); 
    }

    public Product GetByID(int id)
    {
        return _productDal.GetByID(id);
    }

    public List<Product> GetListAll()
    {
        return _productDal.GetListAll();
    }
}