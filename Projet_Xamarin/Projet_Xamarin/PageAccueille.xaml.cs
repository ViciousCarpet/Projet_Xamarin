using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projet_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageAccueille : ContentPage
    {
        public PageAccueille()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            MainPage mp = new MainPage();
            mp.Title = "Bienvenue sur mon appli !";

            /*this.pageAccueille = new NavigationPage(mp)
            {
                BarBackgroundColor = Color.FromHex("#e3f5ab"),
                BarTextColor = Color.Black,
            };*/
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}