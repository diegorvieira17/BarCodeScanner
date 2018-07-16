using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarCodeScanner.Service;
using Foundation;
using UIKit;
using Xamarin.Forms;
using ZXing.Mobile;

[assembly: Dependency(typeof(BarCodeScanner.iOS.Service.QrCodeScanningService))]
namespace BarCodeScanner.iOS.Service
{
    public class QrCodeScanningService : IQrCodeScanningService
    {
        public async Task<string> ScanAsync()
        {
            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Aproxime a câmera do código de barras",
                BottomText = "Toque na tela para focar"
            };

            var scanResults = await scanner.Scan();

            return (scanResults != null) ? scanResults.Text : String.Empty;
        }
    }
}