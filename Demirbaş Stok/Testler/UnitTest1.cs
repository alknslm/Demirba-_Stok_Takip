using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demirbas_Stok_Takip;

namespace Testler
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FileSave save = new FileSave(); 
              
        }
        [TestMethod]
        public void TestMethod2()
        {
            FileSave save = new FileSave();
            P_Arama p = new P_Arama();
        }
        [TestMethod]
        public void TestMethod3()
        {
            FileSave save = new FileSave();
            Oda_Tanımla o = new Oda_Tanımla();
            
        }

    }
}
