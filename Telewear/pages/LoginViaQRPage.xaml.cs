using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telewear.Lib;
using TgSharp.TL;
using TgSharp.TL.Auth;
using Tizen.Wearable.CircularUI.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Telewear {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginViaQRPage : CirclePage {
        public LoginViaQRPage() {
            InitializeComponent();
            Task.Run(async () => { await DoLogin(); });
        }

        public static Stream ToStream(System.Drawing.Image image, ImageFormat format) {
            var stream = new MemoryStream();
            image.Save(stream, format);
            stream.Position = 0;
            return stream;
        }

        private async Task DoLogin() {
            var idReq = new TLRequestExportLoginToken()
            {
                ApiHash = TdConfig.api_hash,
                ApiId = TdConfig.api_id,
                ExceptIds = new TLVector<int>(Array.Empty<int>())
            };
            var clid = await Static.tgClient.SendRequestAsync<TLAbsLoginToken>(idReq);
            var link = $"tg://login?token={Base64Url.Encode(clid.Serialize())}";
            // Generate QR
            var payload = new PayloadGenerator.Url(link);
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20, System.Drawing.Color.White, System.Drawing.Color.Black, true);
            // Tizen stupid
            qrCodeImage.Save("_TempQR.png");
            QrImage.Source = ImageSource.FromFile("_TempQR.png");
            File.Delete("_TempQR.png");
        }
    }
}