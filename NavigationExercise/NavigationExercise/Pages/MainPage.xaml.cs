using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationExercise
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
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

        private void btnCatacombs_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CatacombsPage());
        }

        private async void btnExit_Clicked(object sender, EventArgs e)
        {
            if (NavigationExercise.App.inventory.hasSword)
            {
                bool alertanswer = await DisplayAlert("Win", "Well done, master thief!", "Play again", "Exit game");
                if (alertanswer)
                {
                    NavigationExercise.App.guard.gotCaught = false;
                    NavigationExercise.App.inventory.hasSword = false;
                    NavigationExercise.App.inventory.hasLockPick = false;
                    await Navigation.PopToRootAsync();
                }
                else
                {
                    Environment.Exit(1);
                } 
            }
            else
            {
                bool alertanswer = await DisplayAlert("Exit", "Wanna exit game?", "Exit game", "Keep playing");
                if (alertanswer)
                {
                    Environment.Exit(1);
                }
            }
        }
    }
}
