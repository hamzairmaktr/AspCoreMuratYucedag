using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FeatureManager : IGenericService<Feature>
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureService)
        {
            _featureDal = featureService;
        }

        public void TAdd(Feature t)
        {
            _featureDal.insert(t);
        }

        public void TDelete(Feature t)
        {
            _featureDal.delete(t);
        }

        public Feature TGetById(int id)
        {
            return _featureDal.GetById(id);
        }

        public List<Feature> TGetList()
        {
            return _featureDal.GetAll();
        }

        public void TUpdate(Feature t)
        {
            _featureDal.update(t);
        }
    }
}
