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
    public partial class CatacombsPage : ContentPage
    {
        public CatacombsPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await DisplayAlert("Dead end.", "You have reached a dead end.", null, "ok");

            if (NavigationExercise.App.guard.gotCaught)
            {
                if (!NavigationExercise.App.inventory.hasLockPick)
                {
                    bool alertanswer = await DisplayAlert("Game over!", "Game over!", "Play again", "Exit game");
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
                    NavigationExercise.App.guard.gotCaught = false;
                }
            }
        }

        private void btnGrandHall_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}