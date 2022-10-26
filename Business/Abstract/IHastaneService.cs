using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHastaneService
    {
        List<Hastane> GetAll();
        void AddHastane(Hastane hastane);
        void DeleteHastane(Hastane hastane);
        void UpdateHastane(Hastane hastane);   
    }
}
