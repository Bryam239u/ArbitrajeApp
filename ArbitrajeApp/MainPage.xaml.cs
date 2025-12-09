namespace ArbitrajeApp
{
    public partial class MainPage : ContentPage
    {
        int goles1 = 0;
        int goles2 = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void GolEq1(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEq1.Text))
            {
                txtEq1.Text = "Equipo Local";
            }

            goles1 += 1;
            GolesEq1.Text = goles1.ToString();
        }

        private void NoGol_Eq1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEq1.Text))
            {
                txtEq1.Text = "Equipo Local";
            }

            if (goles1 > 0)
            {
                goles1 -= 1;
                GolesEq1.Text = goles1.ToString();
            }
        }

        private void GolEq2(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEq2.Text))
            {
                txtEq2.Text = "Equipo Visitante";
            }

            goles2 += 1;
            GolesEq2.Text = goles2.ToString();
        }

        private void NoGol_Eq2(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEq2.Text))
            {
                txtEq2.Text = "Equipo Visitante";
            }

            if (goles2 > 0)
            {
                goles2 -= 1;
                GolesEq2.Text = goles2.ToString();
            }
        }

        private void Limpiar(object sender, EventArgs e)
        {
            txtEq1.Text = string.Empty;
            txtEq2.Text = string.Empty;
            goles1 = 0;
            goles2 = 0;
            GolesEq1.Text = goles1.ToString();
            GolesEq2.Text = goles2.ToString();
        }

        private void Final(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEq1.Text))
            {
                txtEq1.Text = "Equipo Local";
            }
            if (string.IsNullOrEmpty(txtEq2.Text))
            {
                txtEq2.Text = "Equipo Visitante";
            }
            string r;

            if (goles1 > goles2)
                r = "Ganador el equipo: " + txtEq1.Text + " " + GolesEq1.Text +" a " + GolesEq2.Text;
            else if (goles1 < goles2)
                r = "Ganador el equipo: " + txtEq2.Text + " " + GolesEq2.Text + " a " + GolesEq1.Text;
            else
                r = "Empate entre " + txtEq1.Text + " y " + txtEq2.Text + " " + GolesEq1.Text + " a " + GolesEq2.Text; ;

            DisplayAlert("Final del Juego", r, "OK");
        }

    }
}
