namespace aBustillosExamen.Views;

public partial class Login : ContentPage
{

    string[] user = { "estudiante2024", "examen1", "NombreEstudiante" };
    string[] pass = { "uisrael2024", "parcial1", "2024" };
    public Login()
    {
        InitializeComponent();
    }

    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        bool loginSuccessful = false;
        string userRegister = "";
        string usuario = txtUsuario.Text;
        Navigation.PushAsync(new Registro(usuario));

        for (int i = 0; i < user.Length; i++)
        {
            if (user[i] == txtUsuario.Text && pass[i] == txtContraseña.Text)
            {
                loginSuccessful = true;
                userRegister = user[i];
                break;
            }
        }

        if (loginSuccessful)
        {
            DisplayAlert("Login exitoso", "Bienvenido " + userRegister, "OK");
            Navigation.PushAsync(new Registro());
        }
        else
        {
            DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
        }
    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {

    }
}