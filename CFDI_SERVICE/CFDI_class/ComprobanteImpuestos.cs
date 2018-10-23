using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace CFDI_SERVICE
{
    public class ComprobanteImpuestos
    {
        [OptionalField]
        private Traslados trasladosField;
        [OptionalField]
        private Retenciones retencionesField;
        public Traslados Traslados
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
        
        public Retenciones Retenciones
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