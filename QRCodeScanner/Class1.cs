using ZXing;
using ZXing.QrCode;
namespace QRCodeScanner
{
    public class QrCodeScanner
    {

        void CreateQrCode(string content, string path, int width, int height)
        {
            var option = new QrCodeEncodingOptions()
            {
                //DisableECI = true,
                CharacterSet = "UTF-8",
                Width = 250,
                Height = 250
            };
            
            var qr = new BarcodeWriter {Options = option, Format = BarcodeFormat.QR_CODE};
            var img =  qr.Write(content);
            img.Save(path);
            
        }

        static void Main(string[] args)
        {
            var scn = new QrCodeScanner();
            scn.CreateQrCode("www.github.com,","here.png",100, 100);
        }
    }
}