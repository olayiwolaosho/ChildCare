using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewDemo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivitiesPage : ContentPage
    {
        public ActivitiesPage()
        {
            InitializeComponent();
        }

        private void Calenderbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Calender());
        }

        private void Attendviewbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AttendantViewPage());
        }
    }
}