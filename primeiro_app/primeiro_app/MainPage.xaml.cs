using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace primeiro_app
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double altura = Convert.ToDouble(txt_altura.Text);
            double peso = Convert.ToDouble(txt_peso.Text);
            double imc = peso / (altura * altura);

            string msg = "";

            if (imc < 18.5)
            {
                msg = "Seu imc é de: " + imc.ToString("0.00") + " Sua Classificação é ABAIXO DO PESO!";

                DisplayAlert("RESULTADO: ", msg,  "ok");           
            }
            if (imc > 18.5 && imc < 24.9)
            {
                msg = "Seu imc é de: " + imc.ToString("0.00") + " Sua Classificação é NORMAL!";

                DisplayAlert("RESULTADO: ", msg, "ok");
            }
            if (imc > 25 && imc < 29.9)
            {
                msg = "Seu imc é de: " + imc.ToString("0.00") + " Sua Classificação é ACIMA DO PESO!";

                DisplayAlert("RESULTADO: ", msg, "ok");
            }


        }
    }
}
