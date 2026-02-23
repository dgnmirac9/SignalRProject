using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concrete;

public class BookingManager:IBookingDal
{
    private readonly IBookingDal _bookingDal;

    public BookingManager(IBookingDal bookingDal)
    {
        _bookingDal = bookingDal;
    }

    public void Add(Booking entity)
    {
        _bookingDal.Add(entity);
    }

    public void Delete(Booking entity)
    {
        _bookingDal.Delete(entity);
    }

    public void Update(Booking entity)
    {
        _bookingDal.Update(entity);
    }

    public Booking GetByID(int id)
    {
        return _bookingDal.GetByID(id);   
    }
    public List<Booking> GetListAll()
    {
        return _bookingDal.GetListAll();
    }
}