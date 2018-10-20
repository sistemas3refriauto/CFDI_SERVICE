using QRCoder;
using System.Drawing;

namespace CFDI_SERVICE
{
    class qr_generate
    {
        public void createFromText(string value)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(value, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(2);
            qrCodeImage.Save("qr.png", System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}