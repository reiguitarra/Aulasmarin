using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TipoPagina
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TipoPagina.TipoPag.Carrousel.TipoPag1();  //MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
