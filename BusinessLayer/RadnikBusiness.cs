using DataLayer.DataRepositories;
using DataLayer.Models;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class RadnikBusiness
    {
        RadnikRepository RadnikRepository;

        public RadnikBusiness()
        {
            this.RadnikRepository = new RadnikRepository();
        }

        public List<Radnik> GetRadnik()
        {
            return RadnikRepository.GetRadnik();
        }
        public bool InsertRadnik(Radnik r)
        {
            int result = RadnikRepository.InsertRadnik(r);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool UpdateRadnik(Radnik r)
        {
            int result = RadnikRepository.UpdateRadnik(r);
            if (result != 0)
                return true;
            else
                return false;
        }

        public bool DeleteRadnik(string rid)
        {
            int result = RadnikRepository.DeleteRadnik(rid);
            if (result != 0)
                return true;
            else
                return false;
        }
    }
}
