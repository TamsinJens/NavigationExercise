using NavigationExercise.Repositories;
using NavigationExercise.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationExercise
{
    public partial class App : Application
    {
        public static GuardService guard = new GuardService() { };
        public static InventoryRepository inventory = new InventoryRepository() 
        { 
            hasSword = false,
            hasLockPick = false
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
