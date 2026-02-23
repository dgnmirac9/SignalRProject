using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concrete;

public class FeatureManager:IFeatureDal
{
    private readonly IFeatureDal _featureDal;

    public FeatureManager(IFeatureDal featureDal)
    {
        _featureDal = featureDal;
    }

    public void Add(Feature entity)
    {
        _featureDal.Add(entity);    
    }

    public void Delete(Feature entity)
    {
        _featureDal.Delete(entity);
    }

    public void Update(Feature entity)
    {
        _featureDal.Update(entity);
    }

    public Feature GetByID(int id)
    { 
        return _featureDal.GetByID(id);
    }

    public List<Feature> GetListAll()
    {
        return _featureDal.GetListAll();
    }
}