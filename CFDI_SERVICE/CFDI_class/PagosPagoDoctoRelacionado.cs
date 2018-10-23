namespace CFDI_SERVICE
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos")]
    public partial class PagosPagoDoctoRelacionado
    {

        private string idDocumentoField;

        private string folioField;

        private string monedaDRField;

        private string metodoDePagoDRField;

        private string numParcialidadField;

        private string impSaldoAntField;

        private string impPagadoField;

        private string impSaldoInsolutoField;


        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IdDocumento
        {
            get
            {
                return this.idDocumentoField;
            }
            set
            {
                this.idDocumentoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Folio
        {
            get
            {
                return this.folioField;
            }
            set
            {
                this.folioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MonedaDR
        {
            get
            {
                return this.monedaDRField;
            }
            set
            {
                this.monedaDRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MetodoDePagoDR
        {
            get
            {
                return this.metodoDePagoDRField;
            }
            set
            {
                this.metodoDePagoDRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumParcialidad
        {
            get
            {
                return this.numParcialidadField;
            }
            set
            {
                this.numParcialidadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ImpSaldoAnt
        {
            get
            {
                return this.impSaldoAntField;
            }
            set
            {
                this.impSaldoAntField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ImpPagado
        {
            get
            {
                return this.impPagadoField;
            }
            set
            {
                this.impPagadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ImpSaldoInsoluto
        {
            get
            {
                return this.impSaldoInsolutoField;
            }
            set
            {
                this.impSaldoInsolutoField = value;
            }
        }
    }

}