namespace aBustillosExamen.Views;

public partial class Registro : ContentPage
{
    string usuarioC;
    double costo;
    double pagoInicial;
    double pagoCuotas;
    double cuotas;
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

    public Registro(string usuario)
    {
        InitializeComponent();
        usuarioC = usuario;
        lblUsuario.Text = "Usuario Conectado " + usuarioC;
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Resumen(nombre, apellido, VA, fecha, ciudad, pagoInicial, pagoCuotas, total));
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        costo = 300;
        pagoInicial = (300 * 0.15);
        txtPagoInicial.Text = pagoInicial.ToString();
        pagoCuotas = (costo - pagoInicial)*0.05;
        txtCuota.Text = pagoCuotas.ToString();
        cuotas = pagoCuotas * 3;

        total = pagoInicial+cuotas;



    }
}