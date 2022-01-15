using DataLayer.DataRepositories;
using DataLayer.Models;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class GostBusiness
    {
        GostRepository gostRepository;

        public GostBusiness()
        {
            gostRepository = new GostRepository();
        }

        public List<Gost> GetGost()
        {
            return gostRepository.GetGost();
        }
        public bool InsertGost(Gost g)
        {
            int result = gostRepository.InsertGost(g);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool UpdateGost(Gost g)
        {
            int result = gostRepository.UpdateGost(g);
            if (result != 0)
                return true;
            else
                return false;
        }

        public bool DeleteGost(string gid)
        {
            int result = gostRepository.DeleteGost(gid);
            if (result != 0)
                return true;
            else
                return false;
        }
    }
}
