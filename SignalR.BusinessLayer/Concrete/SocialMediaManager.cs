using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concrete;

public class SocialMediaManager:ISocialMediaDal
{
    private readonly ISocialMediaDal _socialMediaDal;
    public void Add(SocialMedia entity)
    {
        _socialMediaDal.Add(entity);
    }

    public void Delete(SocialMedia entity)
    {
        _socialMediaDal.Delete(entity);
    }

    public void Update(SocialMedia entity)
    {
        _socialMediaDal.Update(entity);
    }

    public SocialMedia GetByID(int id)
    {
        return _socialMediaDal.GetByID(id);
    }

    public List<SocialMedia> GetListAll()
    {
        return _socialMediaDal.GetListAll();
    }
}