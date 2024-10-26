namespace aBustillosExamen.Views;

public partial class Registro : ContentPage
{
    string usuarioC;
    double porcentajeInicial = 0.15;
    double recargaPorCuota = 0.05;
    double pagoRecarga;
    double cuotaSinRecargo;
    double cuotaConRecargo;
    double pagoMinimo;
    double pagoInicial;
    double pagoRestante;
    double total;
    string nombre;
    string apellido;
    string VA;
    string fecha;
    string ciudad;

    public Registro()
	{
		InitializeComponent();
	}

    public Registro(string userRegister)
    {
        InitializeComponent();
        usuarioC = userRegister;
        lblUsuario.Text = "Usuario Conectado " + usuarioC;
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtName.Text) ||
            string.IsNullOrWhiteSpace(txtApellido.Text) ||
            string.IsNullOrWhiteSpace(txtPagoInicial.Text) ||
            pkVA.SelectedIndex == 0)
        {
            DisplayAlert("Error", "Todos los campos son obligatorios.", "OK");
            return;
        }
        if (pkVA.SelectedIndex != -1)
        {
            nombre = txtName.Text;
            apellido = txtApellido.Text;
            VA = pkVA.SelectedItem.ToString();
            fecha = dpkFecha.Date.ToString("yyyy-MM-dd");
            ciudad = pkCiudad.SelectedItem.ToString();
            Navigation.PushAsync(new Resumen(nombre, apellido, VA, fecha, ciudad, pagoMinimo, cuotaConRecargo, total, usuarioC));
        }

        pkVA.SelectedIndex = -1;
        pkCiudad.SelectedIndex = -1;
        dpkFecha.Date = DateTime.Now;
        txtName.Text = string.Empty;
        txtApellido.Text = string.Empty;
        txtCuota.Text = string.Empty;
        txtPagoInicial.Text = string.Empty;

    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        pagoMinimo = Convert.ToDouble(txtPagoInicial.Text);

        if (pagoMinimo > pagoInicial)
        {
            pagoInicial = pagoMinimo * porcentajeInicial;
            pagoRestante = 300 - pagoMinimo;

            cuotaSinRecargo = pagoRestante / 3;
            cuotaConRecargo = (cuotaSinRecargo * 0.05) + cuotaSinRecargo;
            total = pagoMinimo + (cuotaConRecargo * 3);

            txtCuota.Text = cuotaConRecargo.ToString("F2");
        }
        else
        {
            DisplayAlert("Alerta", "El Pago Inicial debe ser de al menos el 15% del costo", "Cerrar");
        }
    }
}