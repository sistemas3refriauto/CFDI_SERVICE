using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFDI_SERVICE
{
    class processXML
    {
        LeerFacturaComprobantePago fact;
        ReportDocument MyReportDocumenet;


        public void ComprobanteDePago(string RutaXMLs)
        {
            fact = new LeerFacturaComprobantePago();
            string tipfact = fact.tipoFactura(RutaXMLs);
            Comprobante comp = fact.getComprobante;
            qr_generate qr = new qr_generate();
            string qrstring;
            qrstring =
                "&re=" + comp.Emisor.Rfc +
                "&rr" + comp.Receptor.Rfc +
                "&tt" + comp.Total +
                "&id" + comp.Complemento.TimbreFiscalDigital.UUID;
            qr.createFromText(qrstring);
            datosPago _datosPago;
            listaDatosPago _listaDatosPago = new listaDatosPago();
            if (!(comp.Complemento.Pagos.Pago.DoctoRelacionado == null))
            {
                foreach (PagosPagoDoctoRelacionado pago in comp.Complemento.Pagos.Pago.DoctoRelacionado)
                {
                    _datosPago = new datosPago();
                    int.Parse("" + pago.Folio);
                    _datosPago.Folio = "" + pago.Folio;
                    _datosPago.IdDocumento = pago.IdDocumento;
                    _datosPago.ImpPagado = pago.ImpPagado;
                    _datosPago.ImpSalAnt = pago.ImpSaldoAnt;
                    _datosPago.ImpSalInsoluto = pago.ImpSaldoInsoluto;
                    _datosPago.MetodoDePagoDR = pago.MetodoDePagoDR;
                    _datosPago.MonedaDR = pago.MonedaDR;
                    _datosPago.NumParcialidad = pago.NumParcialidad;
                    _listaDatosPago.addDatosPago(_datosPago);

                }
            }
            MyReportDocumenet = null;
            MyReportDocumenet = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            MyReportDocumenet.Load("CrystalReport2.rpt");
            MyReportDocumenet.SetDataSource(_listaDatosPago.getDatosPago());
            MyReportDocumenet.SetParameterValue("TipoDocumento", "COMPROBANTE DE PAGO");
            MyReportDocumenet.SetParameterValue("Nombre", comp.Emisor.Nombre);
            MyReportDocumenet.SetParameterValue("Rfc", comp.Emisor.Rfc);
            MyReportDocumenet.SetParameterValue("Regimen", comp.Emisor.RegimenFiscal);
            MyReportDocumenet.SetParameterValue("FechaExp", comp.Fecha);
            MyReportDocumenet.SetParameterValue("NombreCli", comp.Receptor.Nombre);
            MyReportDocumenet.SetParameterValue("RFCcli", comp.Receptor.Rfc);
            MyReportDocumenet.SetParameterValue("CDFI", comp.Receptor.UsoCFDI);
            MyReportDocumenet.SetParameterValue("CP", comp.LugarExpedicion);
            MyReportDocumenet.SetParameterValue("NoCert", comp.NoCertificado);
            MyReportDocumenet.SetParameterValue("UUID", comp.Complemento.TimbreFiscalDigital.UUID);
            MyReportDocumenet.SetParameterValue("NoCertSat", comp.Complemento.TimbreFiscalDigital.NoCertificadoSAT);
            MyReportDocumenet.SetParameterValue("FechaTrim", comp.Complemento.TimbreFiscalDigital.FechaTimbrado);
            MyReportDocumenet.SetParameterValue("version", comp.Version);
            MyReportDocumenet.SetParameterValue("CelloCfdi", comp.Complemento.TimbreFiscalDigital.SelloCFD);
            MyReportDocumenet.SetParameterValue("SelloSat", comp.Complemento.TimbreFiscalDigital.SelloSAT);
            MyReportDocumenet.SetParameterValue("QR", Application.StartupPath + "\\qr.png");
            MyReportDocumenet.SetParameterValue("TOTAL", comp.Complemento.Pagos.Pago.Monto);
            MyReportDocumenet.SetParameterValue("CforP", comp.Complemento.Pagos.Pago.FormaDePagoP);
            string formaP = "";
            if (comp.Complemento.Pagos.Pago.FormaDePagoP == "01")
                formaP = "Efectivo";
            if (comp.Complemento.Pagos.Pago.FormaDePagoP == "02")
                formaP = "Cheque nominativo";
            if (comp.Complemento.Pagos.Pago.FormaDePagoP == "03")
                formaP = "Transferencia electrónica de fondos";
            MyReportDocumenet.SetParameterValue("CforPD", formaP);
            MyReportDocumenet.SetParameterValue("Mon", comp.Complemento.Pagos.Pago.MonedaP);
            string mond = "";
            if (comp.Complemento.Pagos.Pago.MonedaP == "USD")
                mond = "Dolar Americano";
            if (comp.Complemento.Pagos.Pago.MonedaP == "MXN")
                mond = "Peso Mexicano";
            MyReportDocumenet.SetParameterValue("MonD", mond);

            string folio;
            if (comp.Folio == null)
                folio = "";
            else
                folio = comp.Folio;
            MyReportDocumenet.SetParameterValue("Folio", folio);
            string cadena;
            cadena = "||" + comp.Complemento.TimbreFiscalDigital.Version + "|" +
                comp.Complemento.TimbreFiscalDigital.UUID + "|" +
                comp.Complemento.TimbreFiscalDigital.FechaTimbrado + "|" +
                comp.Complemento.TimbreFiscalDigital.SelloCFD + "|" +
                comp.Complemento.TimbreFiscalDigital.NoCertificadoSAT;
            MyReportDocumenet.SetParameterValue("Cadena", cadena);
        }
        public void ComprobanteDePagoSave(string RutaXMLsArch)
        {
            if (!(MyReportDocumenet != null))
                return;
            string RutaXMLsS = Path.GetDirectoryName(RutaXMLsArch) + @"\";
            string filename = Path.GetFileNameWithoutExtension(RutaXMLsArch);
            string extension = ".pdf";
            string aguardar = RutaXMLsS + filename + extension;
            MyReportDocumenet.ExportToDisk(ExportFormatType.PortableDocFormat, aguardar);
        }
    }
}
