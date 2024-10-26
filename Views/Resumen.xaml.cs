using static Microsoft.Maui.ApplicationModel.Permissions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace aBustillosExamen.Views;
public partial class Resumen : ContentPage
{
	public Resumen(string nombre, string apellido, string VA, string fecha, string ciudad, double pagoMinimo, double cuotaConRecargo, double total, string usuarioC)
	{
		InitializeComponent();
        lblNombre.Text = nombre;
        lblApellido.Text = apellido;
        lblVA.Text = VA;
        lblFecha.Text = fecha;
        lblCiudad.Text = ciudad;
        lblMontoInicial.Text = pagoMinimo.ToString("F2");
        lblCostoMensual.Text = cuotaConRecargo.ToString("F2");
        lblPagoTotal.Text = total.ToString("F2");
        lblUsuario.Text = "Usuario Conectado " + usuarioC;
    }

    private void btnCerrar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Login());
    }
}