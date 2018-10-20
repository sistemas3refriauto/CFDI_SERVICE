using System.Collections.Generic;

namespace CFDI_SERVICE
{
    class listaDatosPago
    {
        List<datosPago> dp;
        public listaDatosPago()
        {
            dp = new List<datosPago>();
        }
        public List<datosPago> getDatosPago()
        {
            return dp;
        }
        public void addDatosPago(datosPago datosP)
        {
            dp.Add(datosP);
        }
    }
}