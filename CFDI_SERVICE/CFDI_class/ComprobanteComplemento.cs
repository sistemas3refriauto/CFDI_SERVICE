namespace CFDI_SERVICE
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public partial class ComprobanteComplemento
    {

        private Pagos pagosField;

        private TimbreFiscalDigital timbreFiscalDigitalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.sat.gob.mx/Pagos")]
        public Pagos Pagos
        {
            get
            {
                return this.pagosField;
            }
            set
            {
                this.pagosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.sat.gob.mx/TimbreFiscalDigital")]
        public TimbreFiscalDigital TimbreFiscalDigital
        {
            get
            {
                return this.timbreFiscalDigitalField;
            }
            set
            {
                this.timbreFiscalDigitalField = value;
            }
        }
    }
}