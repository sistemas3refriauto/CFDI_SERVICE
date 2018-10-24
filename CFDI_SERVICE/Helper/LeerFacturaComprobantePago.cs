using System.Xml;
using System.Xml.Serialization;

namespace CFDI_SERVICE
{
    class LeerFacturaComprobantePago
    {
        #region variables
        string prefix = "cfdi";
        private Comprobante comprobante;
        #endregion
        public string tipoFactura(string rutaXml)
        {
            setComprobante(rutaXml);
            return comprobante.TipoDeComprobante;
        }
        private void setComprobante(string rutaXml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Comprobante));
            XmlTextReader reader = new XmlTextReader(rutaXml);
            comprobante = (Comprobante)serializer.Deserialize(reader);
            
        }
        public Comprobante getComprobante
        {
            get { return comprobante; }
        }
    }
}