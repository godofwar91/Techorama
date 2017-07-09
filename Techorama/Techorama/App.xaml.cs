using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techorama.Views;
using Xamarin.Forms;

namespace Techorama
{
    public partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();
            // The root page of your application
            MainPage = new TechoramaMP(); //nota importante: se è una classe di tipo MatserpAGE, NON SERVE inserirlo in una push di navigazione poichè questa la include per le pagine nel menu
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
