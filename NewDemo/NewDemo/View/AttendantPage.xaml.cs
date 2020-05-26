using NewDemo.View;
using NewDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AttendantPage : ContentPage
    {
        public AttendantPage()
        {
            InitializeComponent();
            BindingContext = new AttendantPageViewModel(this.Navigation);
        }

        //private void View_Clicked(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new AttendantViewPage());
        //}
    }
}