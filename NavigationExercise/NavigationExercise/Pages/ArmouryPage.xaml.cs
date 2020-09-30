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
    public partial class ArmouryPage : ContentPage
    {
        public ArmouryPage()
        {
            InitializeComponent();
        }

        private void btnBarracks_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BarracksPage());
        }

        private void btnGrandHall_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (NavigationExercise.App.guard.GuardingCastle())
            {
                DisplayAlert("Guard", "The guard has caught you. You are taken to the catacombs", null, "ok");
                for (int i = Navigation.NavigationStack.Count()-2; i > 0; i--)
                {
                    Navigation.RemovePage(Navigation.NavigationStack[i]);
                }
                Navigation.PushAsync(new CatacombsPage());
            }
        }
        }
}