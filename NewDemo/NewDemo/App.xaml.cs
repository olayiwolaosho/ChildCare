using Autofac;
using NewDemo.Services;
using NewDemo.ViewModel.AuthenticationViewModel;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewDemo
{
    public partial class App : Application
    {
        public IContainer Container { get; }
        public string AuthToken { get; set; }

        public App(Module module)
        {
            Device.SetFlags(new List<string>() {
                "Expander_Experimental"
            });

            InitializeComponent();

            DependencyService.Register<AttendantFirebaseDataStore>();
            DependencyService.Register<ChildFirebaseDataStore>();
            DependencyService.Register<FirebaseRegistration>();

            Container = BuildContainer(module);
            //MainPage = new NavigationPage(new MainPage());
            MainPage = new MainShell();
        }  
        
        public App()
        {
            Device.SetFlags(new List<string>() {
                "Expander_Experimental"
            });

            InitializeComponent();

            DependencyService.Register<AttendantFirebaseDataStore>();
            DependencyService.Register<ChildFirebaseDataStore>();
            DependencyService.Register<FirebaseRegistration>();

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

        IContainer BuildContainer(Module module)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<AttendantLoginViewModel>().AsSelf();
           builder.RegisterType<NavigationServices>().AsSelf().SingleInstance();
            builder.RegisterModule(module);
            return builder.Build();
        }
    }
}
