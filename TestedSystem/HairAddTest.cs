using HairProvider.InterfaceProvider;
using HairProvider.Provider;
using HairsClientLib.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace TestedSystem
{

    [TestClass]
    public class HairAddTest
    {
        private ManualResetEvent locker = new ManualResetEvent(true);
        iHairProv prov = new HairProv();

        [TestMethod]
        public void TestMethod1()
        {
            prov.Connect += Prov_Connect;
            Prov_Connect();
        }

        private void Prov_Connect()
        {
            locker.WaitOne();
            Hair hair = new Hair
            {
                x1 = 1,
                x2 = 2,
                y1 = 3,
                y2 = 4
            };
            prov.Add(hair);

            Assert.AreSame(prov.Add(hair),hair);
        }
    }
}
