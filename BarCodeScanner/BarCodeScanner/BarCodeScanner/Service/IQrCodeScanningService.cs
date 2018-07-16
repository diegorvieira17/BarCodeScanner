using System.Threading.Tasks;

namespace BarCodeScanner.Service
{
    public interface IQrCodeScanningService
    {
        Task<string> ScanAsync();
    }
}
