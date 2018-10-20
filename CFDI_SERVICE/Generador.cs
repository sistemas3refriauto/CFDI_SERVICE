using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFDI_SERVICE
{
    class Generador
    {
        private string[] UbicacionesXml;
        processXML _processX;
        #region archivo unico
        public void setXML(string path)
        {
            _processX = new processXML();
        }
        public void setXML(string path, bool print)
        {
            setXML(path);
            //TODO Codigo para mandar a imprimir
        }
        public void setXML(string path, bool print, bool email)
        {
            setXML(path,print);
            //TODO Codigo para mandar por correo electronico
        }
        #endregion
        #region archivo multiple
        public void setXML(string[] path)
        {
            UbicacionesXml = path;
            foreach(string var in UbicacionesXml)
            {
                setXML(var);
            }
        }
        public void setXML(string[] path, bool print)
        {
            UbicacionesXml = path;
            foreach (string var in UbicacionesXml)
            {
                setXML(var, print);
            }
        }
        public void setXML(string[] path, bool print, bool email)
        {
            UbicacionesXml = path;
            foreach (string var in UbicacionesXml)
            {
                setXML(var, print,email);
            }
        }
        #endregion

    }
}
