namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;

            if (vez == "X")
            {

                btn.Text = "X";
                vez = "O";
            }
            else
            {
                btn.Text = "O";
                vez = "X";
            }

            /*Verificando quem venceu na primeira linha */
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                DisplayAlert("Parabéns!", "X ganhou!", "OK");
                Zerar();
            }
            if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                DisplayAlert("Parabéns!", "O ganhou!", "OK");
                Zerar();
            }

        } // Fechamento Metodo

        void Zerar()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn10.IsEnabled = false;
            btn11.IsEnabled = false;
            btn12.IsEnabled = false;

            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn20.IsEnabled = false;
            btn21.IsEnabled = false;
            btn22.IsEnabled = false;

            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";
            btn30.IsEnabled = false;
            btn31.IsEnabled = false;
            btn32.IsEnabled = false;

        }

    } // Fecha Classe
} // Fecha Namespace
