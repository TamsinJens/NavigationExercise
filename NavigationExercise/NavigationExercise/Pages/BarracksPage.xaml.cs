using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarracksPage : ContentPage
    {
        public BarracksPage()
        {
            InitializeComponent();
        }

        private void btnThroneRoom_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ThroneRoomPage());
        }

        private void btnArmoury_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ArmouryPage());
        }

        private void btnOpenChest_Clicked(object sender, EventArgs e)
        {
            var chest = new ChestPage();
            Navigation.PushModalAsync(chest, true);
        }
    }
}