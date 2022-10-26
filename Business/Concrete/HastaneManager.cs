using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class HastaneManager : IHastaneService
    {
        IHospitalDal _hospitalDal;
        public HastaneManager(IHospitalDal hospitalDal)
        {
            _hospitalDal= hospitalDal;  
        }
        public void AddHastane(Hastane hastane)
        {   if(hastane.hastane_ad.Length<10)
            { _hospitalDal.Add(hastane); }
          
        }

        public void DeleteHastane(Hastane hastane)
        {
          
                _hospitalDal.Delete(hastane);

            
           
            
        }

        public List<Hastane> GetAll()
        {
            return _hospitalDal.GetAll();
        }

        public void UpdateHastane(Hastane hastane)
        {
            _hospitalDal.Update(hastane);
        }
    }
}
