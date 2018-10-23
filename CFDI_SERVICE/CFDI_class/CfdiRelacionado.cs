namespace CFDI_SERVICE
{
    public class CfdiRelacionado
    {
        private string UUIDfield;
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UUID
        {
            get
            {
                return this.UUIDfield;
            }
            set
            {
                this.UUIDfield = value;
            }
        }
    }
}