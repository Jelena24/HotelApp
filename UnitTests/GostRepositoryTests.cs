using DataLayer.DataRepositories;
using DataLayer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace RadnikUnitTests
{
    [TestClass]
    public class GostRepositoryTests
    {

        Gost gost;
        GostRepository gostRepository;

        [TestInitialize]
        public void init()
        {
            gost = new Gost("2245785", "Ana", "Matic", "0624578956", 2);
            gostRepository = new GostRepository();
        }

        [TestMethod()]
        public void GetGostTest()
        {
            gostRepository.InsertGost(gost);
            Assert.IsNotNull(gostRepository.GetGost());
        }

        [TestMethod()]
        public void UpdateGostTest()
        {
            gostRepository.InsertGost(gost);
            Gost g = gostRepository.GetGost().Where(x => x.BrojLicneKarte == gost.BrojLicneKarte).ToList()[0];
            int rezultat = gostRepository.UpdateGost(g);
            Assert.IsTrue(rezultat > 0);
        }

        [TestMethod()]
        public void DeleteGostTest()
        {
            gostRepository.InsertGost(gost);
            Gost g = gostRepository.GetGost().Where(x => x.BrojLicneKarte == gost.BrojLicneKarte).ToList()[0];
            int rezultat = gostRepository.DeleteGost(g.BrojLicneKarte);
            gostRepository.InsertGost(g);
            Assert.IsTrue(rezultat > 0);
        }

        [TestCleanup]
        public void Clean()
        {
            Gost g = gostRepository.GetGost().Where(x => x.BrojLicneKarte == gost.BrojLicneKarte).ToList()[0];
            gostRepository.DeleteGost(g.BrojLicneKarte);
        }
    }
}
