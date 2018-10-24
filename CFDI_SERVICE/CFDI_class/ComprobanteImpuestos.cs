using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace CFDI_SERVICE
{
    public class ComprobanteImpuestos
    {
        [OptionalField]
        private TrasladosTraslado[] trasladosField;
        [OptionalField]
        private TrasladosRetenciones[] retencionesField;
        public TrasladosTraslado[] Traslados
        {
            set
            {
                trasladosField = value;
            }
            get
            {
                return trasladosField;
            }
        }
        
        public TrasladosRetenciones[] Retenciones
        {
            set
            {
                retencionesField = value;
            }
            get
            {
                return retencionesField;
            }
        }
    }
}