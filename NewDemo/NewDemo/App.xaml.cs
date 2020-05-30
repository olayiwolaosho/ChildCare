using NewDemo.Services;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewDemo
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new List<string>() {
                "Expander_Experimental"
            });

            InitializeComponent();

            DependencyService.Register<AttendantFirebaseDataStore>();
            DependencyService.Register<ChildFirebaseDataStore>();

            //MainPage = new NavigationPage(new MainPage());
            MainPage = new MainShell();
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
