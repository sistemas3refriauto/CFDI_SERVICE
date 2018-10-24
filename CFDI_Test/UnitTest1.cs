using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CFDI_SERVICE;


namespace CFDI_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCOmprobantesDePago()
        {
            //TODO: codigo para el test
            List<string> ComprobantesDePago = new List<string>();
            foreach (string comprobante in ComprobantesDePago)
            {
                Generador.setXML(comprobante, "");
            }
        }
    }
}
