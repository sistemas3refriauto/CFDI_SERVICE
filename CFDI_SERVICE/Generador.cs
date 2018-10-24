using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFDI_SERVICE
{
    public static class Generador
    {
        private static string[] UbicacionesXml;
        static processXML _processX;
        #region archivo unico
        public static string setXML(string RutaXMLs, string ruta)
        {
            try
            {
                _processX = null;
                _processX = new processXML();
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static string setXML(string RutaXMLs, string ruta, bool print)
        {
            try
            {
                setXML(RutaXMLs, ruta);
                //TODO Codigo para mandar a imprimir
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static string setXML(string RutaXMLs, string ruta, bool print, bool email)
        {
            try
            {
                setXML(RutaXMLs, ruta, print);
                //TODO Codigo para mandar por correo electronico
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion
        #region archivo multiple
        public static string setXML(string[] RutaXMLs, string ruta)
        {
            try
            {
                UbicacionesXml = RutaXMLs;
                foreach (string var in UbicacionesXml)
                {
                    setXML(var, ruta);
                }
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static string setXML(string[] RutaXMLs, string ruta, bool print)
        {
            try
            {
                UbicacionesXml = RutaXMLs;
                foreach (string var in UbicacionesXml)
                {
                    setXML(var, ruta, print);
                }
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static string setXML(string[] RutaXMLs, string ruta, bool print, bool email)
        {
            try
            {
                UbicacionesXml = RutaXMLs;
                foreach (string var in UbicacionesXml)
                {
                    setXML(var, ruta, print, email);
                }
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion

    }
}
