using System.Runtime.Serialization;
using System.Xml.Serialization;
namespace CFDI_SERVICE
{
    public class TrasladosTraslado
    {
        #region variables
        private string baseField;
        private string impuestoField;
        private string tipoFactorField;
        [OptionalField]
        private string TasaOCoutaField;
        [OptionalField]
        private string importeField;
        #endregion

        [XmlAttributeAttribute()]
        public string Base
        {
            get { return baseField; }
            set { baseField = value; }
        }
        [XmlAttributeAttribute()]
        public string Impuestos
        {
            get { return impuestoField; }
            set { impuestoField = value; }
        }
        [XmlAttributeAttribute()]
        public string TipoFactor
        {
            get { return tipoFactorField; }
            set { tipoFactorField = value; }
        }
        [XmlAttributeAttribute()]
        public string TasaOCouta
        {
            get { return TasaOCoutaField; }
            set { TasaOCoutaField = value; }
        }
        [XmlAttributeAttribute()]
        public string Importe
        {
            get { return importeField; }
            set { importeField = value; }
        }
    }
}