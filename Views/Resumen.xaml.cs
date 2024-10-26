using static Microsoft.Maui.ApplicationModel.Permissions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace aBustillosExamen.Views;
public partial class Resumen : ContentPage
{
	public Resumen(string nombre, string apellido, string VA, string fecha, string ciudad,double pagoInicial, double pagoCuotas, double total )
	{
		InitializeComponent();
	}

    private void btnCerrar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Login());
    }
}