using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
namespace CFDI_SERVICE
{
    class email_sender
    {
        DatosMail datosMail;
        public email_sender(DatosMail dm)
        {
            datosMail = dm;
        }
        public string send()
        {
            try
            {
                var fromAddress = new MailAddress(datosMail.from);
                var toAddress = new MailAddress(datosMail.to);
                string fromPassword = datosMail.FromPassword;
                string subject = datosMail.subjet;
                string body = datosMail.body;

                var smtp = new SmtpClient
                {
                    Host = datosMail.host,
                    Port = datosMail.port,
                    EnableSsl = datosMail.enableSSl,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = datosMail.UseDefaultCredentials,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
