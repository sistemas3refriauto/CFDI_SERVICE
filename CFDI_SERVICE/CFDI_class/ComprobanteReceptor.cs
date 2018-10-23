using System.Runtime.Serialization;

namespace CFDI_SERVICE
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public partial class ComprobanteReceptor
    {

        private string rfcField;
        [OptionalField]
        private string nombreField;
        [OptionalField]
        private string residenciaFiscalField;
        private string usoCFDIField;
        [OptionalField]
        private string NumRegIdTribField;
        System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumRegIdTrib
        {
            get
            {
                return this.NumRegIdTribField;
            }
            set
            {
                this.NumRegIdTribField = value;
            }
        }

        System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResidenciaFiscalField
        {
            get
            {
                return this.residenciaFiscalField;
            }
            set
            {
                this.residenciaFiscalField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Rfc
        {
            get
            {
                return this.rfcField;
            }
            set
            {
                this.rfcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Nombre
        {
            get
            {
                return this.nombreField;
            }
            set
            {
                this.nombreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UsoCFDI
        {
            get
            {
                return this.usoCFDIField;
            }
            set
            {
                this.usoCFDIField = value;
            }
        }
    }

}