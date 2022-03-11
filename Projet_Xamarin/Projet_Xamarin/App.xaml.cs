using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projet_Xamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage mp = new MainPage();
            mp.Title = "Bienvenue sur mon appli !";

            this.MainPage = new NavigationPage(mp)
            {
                BarBackgroundColor = Color.FromHex("#e3f5ab"),
                BarTextColor = Color.Black,    
            };
            //MainPage = new IntroAXamarin.MainPage();
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
