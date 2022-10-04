using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Sumas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina_Resultado : ContentPage
    {
        public Pagina_Resultado(String Datos)
        {
            InitializeComponent();
            
         lblresultado.Text = "El Resultado es: " + Datos;
        

        }
    }
}