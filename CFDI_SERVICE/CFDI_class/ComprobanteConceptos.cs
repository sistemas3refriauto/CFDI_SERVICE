namespace CFDI_SERVICE
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public class ComprobanteConceptos
    {

        private ComprobanteConceptosConcepto conceptoField;

        /// <remarks/>
        public ComprobanteConceptosConcepto Concepto
        {
            get
            {
                return this.conceptoField;
            }
            set
            {
                this.conceptoField = value;
            }
        }
    }
}