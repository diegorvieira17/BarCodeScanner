using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarCodeScanner.Service;
using Xamarin.Forms;

namespace BarCodeScanner
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    private async void Button_OnClicked(object sender, EventArgs e) => await OpenScan();

	    private async Task OpenScan()
	    {
	        var scanner = DependencyService.Get<IQrCodeScanningService>();
	        var result = await scanner.ScanAsync();
	        if (!string.IsNullOrEmpty(result))
	        {
	            lblResultado.Text = result;
	        }
	        else
	        {
	            lblResultado.Text = "Código de barras não identificado!";
	        }
	    }
	}
}
