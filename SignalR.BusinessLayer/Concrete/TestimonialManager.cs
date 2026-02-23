using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concrete;

public class TestimonialManager:ITestimonialDal
{
    private readonly ITestimonialDal _testimonialDal;

    public TestimonialManager(ITestimonialDal testimonialDal)
    {
        _testimonialDal = testimonialDal;
    }

    public void Add(Testimonial entity)
    {
        _testimonialDal.Add(entity);
    }

    public void Delete(Testimonial entity)
    {
        _testimonialDal.Delete(entity);
    }

    public void Update(Testimonial entity)
    {
        _testimonialDal.Update(entity);
    }

    public Testimonial GetByID(int id)
    {
        return _testimonialDal.GetByID(id);
    }

    public List<Testimonial> GetListAll()
    {
        return _testimonialDal.GetListAll();    
    }
}