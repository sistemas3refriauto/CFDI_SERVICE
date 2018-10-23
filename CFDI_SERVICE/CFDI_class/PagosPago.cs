namespace CFDI_SERVICE
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos")]
    public class PagosPago
    {

        private PagosPagoDoctoRelacionado[] doctoRelacionadoField;

        private string fechaPagoField;

        private string formaDePagoPField;

        private string monedaPField;

        private string montoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DoctoRelacionado")]
        public PagosPagoDoctoRelacionado[] DoctoRelacionado
        {
            get
            {
                return this.doctoRelacionadoField;
            }
            set
            {
                this.doctoRelacionadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FechaPago
        {
            get
            {
                return this.fechaPagoField;
            }
            set
            {
                this.fechaPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FormaDePagoP
        {
            get
            {
                return this.formaDePagoPField;
            }
            set
            {
                this.formaDePagoPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MonedaP
        {
            get
            {
                return this.monedaPField;
            }
            set
            {
                this.monedaPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Monto
        {
            get
            {
                return this.montoField;
            }
            set
            {
                this.montoField = value;
            }
        }
    }
}