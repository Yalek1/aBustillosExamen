namespace aBustillosExamen.Views;

public partial class Login : ContentPage
{

    string[] user = { "estudiante2024", "examen1", "Alexander" };
    string[] pass = { "uisrael2024", "parcial1", "2024" };
    string userRegister = "";
    public Login()
    {
        InitializeComponent();
    }

    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        bool loginSuccessful = false;

        for (int i = 0; i < user.Length; i++)
        {
            if (user[i] == txtUsuario.Text && pass[i] == txtContraseña.Text)
            {
                loginSuccessful = true;
                userRegister = user[i];
            }
        }

        if (loginSuccessful)
        {
            DisplayAlert("Login exitoso", "Bienvenido " + userRegister, "OK");
            Navigation.PushAsync(new Registro(userRegister));
        }
        else
        {
            DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
        }
    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
            string.IsNullOrWhiteSpace(txtContraseña.Text))
        {
            DisplayAlert("Error", "Todos los campos deben ser llenados", "OK");
        }
        else
        {
            string message = "Usuario Conectado " + txtUsuario.Text + "\n" +
            "\nNombre: Alexander Bustillos" +
            "\nCurso: Octavo B" +
            "\nCarrera: Sistemas de Información";
            DisplayAlert("Información Estudiante", message, "Cerrar");
        }
    }
}