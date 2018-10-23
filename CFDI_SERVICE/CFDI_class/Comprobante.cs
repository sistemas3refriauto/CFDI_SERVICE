using System.Runtime.Serialization;

namespace CFDI_SERVICE
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.sat.gob.mx/cfd/3", IsNullable = false)]
    public partial class Comprobante
    {
        #region variables
        [OptionalField]
        private ComprobanteCfdiRelacionados cfdiRelacionadosField;
        private ComprobanteEmisor emisorField;
        private ComprobanteReceptor receptorField;
        private ComprobanteConceptos conceptosField;
        [OptionalField]
        private ComprobanteImpuestos impuestosField;
        [OptionalField]
        private ComprobanteComplemento complementoField;
        [OptionalField]
        private ComprobanteAddenda addendaField;

        private string lugarExpedicionField;
        private string tipoDeComprobanteField;
        private string totalField;
        private string monedaField;
        private string certificadoField;
        private string subTotalField;
        private string noCertificadoField;
        private string selloField;
        private string fechaField;
        [OptionalField]
        private string formaPagoField;
        private string versionField;
        [OptionalField]
        private string folioField;
        [OptionalField]
        private string serieField;
        [OptionalField]
        private string condicionesDePagoField;
        [OptionalField]
        private string descuentoField;
        [OptionalField]
        private string TipoCambioField;
        [OptionalField]
        private string MetodoPagoField;
        [OptionalField]
        private string confirmacionField;
        #endregion
        /// <remarks/>
        /// 
        /// 
        public ComprobanteAddenda Addena
        {
            get
            {
                return this.addendaField;
            }
            set
            {
                this.addendaField = value;
            }
        }
        public ComprobanteCfdiRelacionados CfdiRelacionados
        {
            get
            {
                return this.cfdiRelacionadosField;
            }
            set
            {
                this.cfdiRelacionadosField = value;
            }
        }
        public ComprobanteEmisor Emisor
        {
            get
            {
                return this.emisorField;
            }
            set
            {
                this.emisorField = value;
            }
        }

        /// <remarks/>
        public ComprobanteReceptor Receptor
        {
            get
            {
                return this.receptorField;
            }
            set
            {
                this.receptorField = value;
            }
        }

        /// <remarks/>
        public ComprobanteConceptos Conceptos
        {
            get
            {
                return this.conceptosField;
            }
            set
            {
                this.conceptosField = value;
            }
        }

        /// <remarks/>
        public ComprobanteComplemento Complemento
        {
            get
            {
                return this.complementoField;
            }
            set
            {
                this.complementoField = value;
            }
        }
        public ComprobanteImpuestos Impuestos
        {
            get
            {
                return this.impuestosField;
            }
            set
            {
                this.impuestosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LugarExpedicion
        {
            get
            {
                return this.lugarExpedicionField;
            }
            set
            {
                this.lugarExpedicionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoDeComprobante
        {
            get
            {
                return this.tipoDeComprobanteField;
            }
            set
            {
                this.tipoDeComprobanteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Moneda
        {
            get
            {
                return this.monedaField;
            }
            set
            {
                this.monedaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Certificado
        {
            get
            {
                return this.certificadoField;
            }
            set
            {
                this.certificadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SubTotal
        {
            get
            {
                return this.subTotalField;
            }
            set
            {
                this.subTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NoCertificado
        {
            get
            {
                return this.noCertificadoField;
            }
            set
            {
                this.noCertificadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Sello
        {
            get
            {
                return this.selloField;
            }
            set
            {
                this.selloField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Fecha
        {
            get
            {
                return this.fechaField;
            }
            set
            {
                this.fechaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Serie
        {
            get
            {
                return this.serieField;
            }
            set
            {
                this.serieField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FormaDePago
        {
            get
            {
                return this.formaPagoField;
            }
            set
            {
                this.formaPagoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CondicionesDePago
        {
            get
            {
                return this.condicionesDePagoField;
            }
            set
            {
                this.condicionesDePagoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Descuento
        {
            get
            {
                return this.descuentoField;
            }
            set
            {
                this.descuentoField = value;
            }
        }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoCambio
        {
            get
            {
                return this.TipoCambioField;
            }
            set
            {
                this.TipoCambioField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MetodoPago
        {
            get
            {
                return this.MetodoPagoField;
            }
            set
            {
                this.MetodoPagoField = value;
            }
        }
        
            [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Confirmacion
        {
            get
            {
                return this.confirmacionField;
            }
            set
            {
                this.confirmacionField = value;
            }
        }
    }

    
}