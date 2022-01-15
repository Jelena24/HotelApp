using DataLayer.DataRepositories;
using DataLayer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace RadnikUnitTests
{
    [TestClass]
    public class SobaRepositoryTests
    {
        Soba soba;
        SobaRepository sobaRepository;

        [TestInitialize]
        public void init()
        {
            soba = new Soba(3, 1,2,40);
            sobaRepository = new SobaRepository();
        }

        [TestMethod()]
        public void GetSobaTest()
        {
            sobaRepository.InsertSoba(soba);
            Assert.IsNotNull(sobaRepository.GetSoba());
        }

        [TestMethod()]
        public void UpdateSobaTest()
        {
            sobaRepository.InsertSoba(soba);
            Soba s = sobaRepository.GetSoba().Where(x => x.BrojSobe== soba.BrojSobe).ToList()[0];
            int rezultat = sobaRepository.UpdateSoba(s);
            Assert.IsTrue(rezultat > 0);
        }

        [TestMethod()]
        public void DeleteSobaTest()
        {
            sobaRepository.InsertSoba(soba);
            Soba s = sobaRepository.GetSoba().Where(x => x.BrojSobe == soba.BrojSobe).ToList()[0];
            int rezultat = sobaRepository.DeleteSoba(s.BrojSobe);
            sobaRepository.InsertSoba(s);
            Assert.IsTrue(rezultat > 0);
        }

        [TestCleanup]
        public void Clean()
        {
            Soba s = sobaRepository.GetSoba().Where(x => x.BrojSobe == soba.BrojSobe).ToList()[0];
            sobaRepository.DeleteSoba(s.BrojSobe);
        }
    }
}
