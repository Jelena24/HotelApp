using DataLayer.DataRepositories;
using DataLayer.Models;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class SobaBusiness
    {
        SobaRepository SobaRepository;

        public SobaBusiness()
        {
            this.SobaRepository = new SobaRepository();
        }

        public List<Soba> GetSoba()
        {
            return SobaRepository.GetSoba();
        }
        public bool InsertSoba(Soba s)
        {
            int result = SobaRepository.InsertSoba(s);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool UpdateSoba(Soba s)
        {
            int result = SobaRepository.UpdateSoba(s);
            if (result != 0)
                return true;
            else
                return false;
        }

        public bool DeleteSoba(int sid)
        {
            int result = SobaRepository.DeleteSoba(sid);
            if (result != 0)
                return true;
            else
                return false;
        }
    }
}
