using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sumas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Sumar_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Numero1.Text) || (String.IsNullOrEmpty(Numero2.Text))){
                _ = DisplayAlert("Campos Vacios", "Hay un Campo Vacio! Favor Llenar Ambos Campos", "Volver");
            }
            else
            {
          
            int n1 = Convert.ToInt32(Numero1.Text);
            int n2 = Convert.ToInt32(Numero2.Text);
            int suma = n1 + n2;

            await Navigation.PushAsync(new Pagina_Resultado( suma.ToString()));
            }
        }

        private async void Restar_Clicked(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(Numero1.Text) || (String.IsNullOrEmpty(Numero2.Text)))
            {
                _ = DisplayAlert("Campos Vacios", "Hay un Campo Vacio! Favor Llenar Ambos Campos", "Volver");
            }
            else
            {

                int n1 = Convert.ToInt32(Numero1.Text);
            int n2 = Convert.ToInt32(Numero2.Text);
            int resta = n1 - n2;

            await Navigation.PushAsync(new Pagina_Resultado(resta.ToString()));
            }
        
    }

    private async void Multiplicar_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Numero1.Text) || (String.IsNullOrEmpty(Numero2.Text)))
            {
                _ = DisplayAlert("Campos Vacios", "Hay un Campo Vacio! Favor Llenar Ambos Campos", "Volver");
            }
            else
            {
                int n1 = Convert.ToInt32(Numero1.Text);
            int n2 = Convert.ToInt32(Numero2.Text);
            int multiplicar = n1 * n2;

            await Navigation.PushAsync(new Pagina_Resultado(multiplicar.ToString()));

        }
        }

        private async void Dividir_Clicked(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(Numero1.Text);
            int n2 = Convert.ToInt32(Numero2.Text);
            if (n2.Equals(0))
            {
                _ = DisplayAlert("Division entre Cero", "El Valor a dividir es igual a Cero, Esto Provacaria una Excepcion de Error", "Volver");
            }

           else if (String.IsNullOrEmpty(Numero1.Text) || (String.IsNullOrEmpty(Numero2.Text)))
                {
                    _ = DisplayAlert("Campos Vacios", "Hay un Campo Vacio! Favor Llenar Ambos Campos", "Volver");
                }
                else
                {
            
            int dividir = n1 / n2;
            await Navigation.PushAsync(new Pagina_Resultado(dividir.ToString()));           

        }
            
        }
    }
}
