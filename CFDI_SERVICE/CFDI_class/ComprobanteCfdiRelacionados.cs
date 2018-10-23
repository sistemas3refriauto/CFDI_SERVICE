using System.Runtime.Serialization;

namespace CFDI_SERVICE
{
    public class ComprobanteCfdiRelacionados
    {
        private string tipoRelacionField;
        [OptionalField]
        private CfdiRelacionado[] cfdiRelacionado;
        public CfdiRelacionado[] CfdiRelacionado
        {
            get { return cfdiRelacionado; }
            set { cfdiRelacionado = value; }
        }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoRelacion
        {
            get
            {
                return this.tipoRelacionField;
            }
            set
            {
                this.tipoRelacionField = value;
            }
        }

    }
}