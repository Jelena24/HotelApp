using DataLayer.DataRepositories;
using DataLayer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace RadnikUnitTests
{
    [TestClass()]
    public class RadnikRepositoryTests
    {
        Radnik radnik;
        RadnikRepository radnikRepository;

        [TestInitialize]
        public void init()
        {
            radnik = new Radnik("22558645", "David", "Popovic", "0658978852","Hotelijer", "David", "david@gmail.com", "David");
            radnikRepository = new RadnikRepository();
        }

        [TestMethod()]
        public void GetRadnikTest()
        {
            radnikRepository.InsertRadnik(radnik);
            Assert.IsNotNull(radnikRepository.GetRadnik());
        }

        [TestMethod()]
        public void UpdateRadnikTest()
        {
            radnikRepository.InsertRadnik(radnik);
            Radnik r = radnikRepository.GetRadnik().Where(x => x.Username == radnik.Username).ToList()[0];
            r.Password = "pass";
            int rezultat = radnikRepository.UpdateRadnik(r);
            Assert.IsTrue(rezultat > 0);
        }

        [TestMethod()]
        public void DeleteRadnikTest()
        {
            radnikRepository.InsertRadnik(radnik);
            Radnik r = radnikRepository.GetRadnik().Where(x => x.Username == radnik.Username).ToList()[0];
            int rezultat = radnikRepository.DeleteRadnik(r.BrojLicneKarte);
            radnikRepository.InsertRadnik(r);
            Assert.IsTrue(rezultat > 0);
        }

        [TestCleanup]
        public void Clean()
        {
            Radnik r = radnikRepository.GetRadnik().Where(x => x.Username == radnik.Username).ToList()[0];
            radnikRepository.DeleteRadnik(r.BrojLicneKarte);
        }
    }
}

