using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concrete;

public class ContactManager : IContactDal
{
    private readonly IContactDal _contactDal;

    public ContactManager(IContactDal contactDal)
    {
        _contactDal = contactDal;
    }

    public void Add(Contact entity)
    {
        _contactDal.Add(entity);
    }

    public void Delete(Contact entity)
    {
        _contactDal.Delete(entity);
    }

    public void Update(Contact entity)
    {
        _contactDal.Update(entity);
    }

    public Contact GetByID(int id)
    {
        return _contactDal.GetByID(id);
    }

    public List<Contact> GetListAll()
    {
        return _contactDal.GetListAll();
    }
}