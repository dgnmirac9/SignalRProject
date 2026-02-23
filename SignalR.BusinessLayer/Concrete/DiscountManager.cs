using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concrete;

public class DiscountManager:IDiscountDal
{
    public DiscountManager(IDiscountDal discountDal)
    {
        _discountDal = discountDal;
    }

    private readonly IDiscountDal _discountDal;
    public void Add(Discount entity)
    {
        _discountDal.Add(entity);
    }

    public void Delete(Discount entity)
    {
        _discountDal.Delete(entity);
    }

    public void Update(Discount entity)
    {
        _discountDal.Update(entity);
    }

    public Discount GetByID(int id)
    {
        return _discountDal.GetByID(id);
    }

    public List<Discount> GetListAll()
    {
        return _discountDal.GetListAll();
    }
}