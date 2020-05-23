using NewDemo.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<AttendantFirebaseDataStore>();
            DependencyService.Register<ChildFirebaseDataStore>();

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
