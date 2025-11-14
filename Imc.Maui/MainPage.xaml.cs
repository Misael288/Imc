namespace Imc.Maui
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {

            
            InitializeComponent();
            ImcLabel.Text = string.Empty;
            SituacionNutricionalLabel.Text = string.Empty;
        }

        private void OnCalcularButtonClicked(object sender, EventArgs e)
        {
            decimal peso = Convert.ToDecimal(PesoEntry.Text);
            decimal estatura = Convert.ToDecimal(EstaturaEntry.Text);
            decimal imc = peso / (estatura * estatura);


            string situacionNutricional = string.Empty;

            ImcLabel.Text = imc.ToString("G6");
            if (imc < 18.5m)
            {

                situacionNutricional = "Peso bajo";


            }
            else if (imc < 25.0m)
            {

                situacionNutricional = "Peso normal";
            }
            else if (imc < 30.0m)
            {

                situacionNutricional = "Sobre peso";



            }
            else if (imc < 40.0m)
            {


                situacionNutricional = "Obesidad";

            }
            else
            {
                situacionNutricional = "Obesidad Extrema";
            }
            SituacionNutricionalLabel.Text = situacionNutricional;

        }
            



        private void OnLimpiarButtonClicked(object sender, EventArgs e)
        {
            PesoEntry.Text= string.Empty;
            EstaturaEntry.Text = string.Empty;
            ImcLabel.Text= string.Empty;
            SituacionNutricionalLabel.Text= string.Empty;
        }
    }
}
