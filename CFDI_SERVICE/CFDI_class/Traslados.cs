using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace CFDI_SERVICE
{
    public class Traslados
    {
        private TrasladosTraslado trasladoField;
        public TrasladosTraslado Traslado
        {
            get
            {
                return trasladoField;
            }
            set { trasladoField = value; }
        }
    }
}