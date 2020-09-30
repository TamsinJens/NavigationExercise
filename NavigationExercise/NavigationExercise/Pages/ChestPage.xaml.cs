using NavigationExercise.Repositories;
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
    public partial class ChestPage : ContentPage
    {
        public ChestPage()
        {
            InitializeComponent();
        }

        private void btnClose_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(true);
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        private void btnSword_Clicked(object sender, EventArgs e)
        {
            NavigationExercise.App.inventory.hasSword = true;
            DisplayAlert("Sword", "You took the sword", null, "ok");
            btnSword.IsEnabled = false;
        }

        private void btnLockPick_Clicked(object sender, EventArgs e)
        {
            NavigationExercise.App.inventory.hasLockPick = true;
            DisplayAlert("Lockpick", "You took the lockpick", null, "ok");
            btnLockPick.IsEnabled = false;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if(NavigationExercise.App.inventory.hasSword && NavigationExercise.App.inventory.hasLockPick)
            {
                DisplayAlert("Empty", "The chest is empty!", null, "ok");
                btnLockPick.IsEnabled = false;
                btnSword.IsEnabled = false;
            }

            if (NavigationExercise.App.inventory.hasSword)
            {
                btnSword.IsEnabled = false;
            }           
            
            if (NavigationExercise.App.inventory.hasLockPick)
            {
                btnLockPick.IsEnabled = false;
            }
        }
        }
}