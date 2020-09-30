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
    public partial class ThroneRoomPage : ContentPage
    {
        public ThroneRoomPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ShowActions();
            if (NavigationExercise.App.guard.GuardingCastle())
            {
                for (int i = Navigation.NavigationStack.Count(); i > 0; i--)
                {
                    //Navigation.RemovePage(Navigation.NavigationStack[i]);
                }
                Navigation.PushAsync(new CatacombsPage());
            }
        }

        public async void ShowActions()
        {
            string action = await DisplayActionSheet("A grand feast is going on!", null, null, "Attend the party", "◁Sneak into the barracks", "▽To GrandHall");
            if (action == "Attend the party")
            {
                await Task.Delay(5000);
                await DisplayAlert("Wait 5 seconds", "You have feasted with your generous hosts", "Ok");
                ShowActions();
            }
            else if(action == "◁Sneak into the barracks")
            {
                await Navigation.PushAsync(new BarracksPage());
            }
            else if(action == "▽To GrandHall")
            {
                await Navigation.PopToRootAsync();
            }
        }
    }
}