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
        }

        private void ProfileView_Clicked(object sender, EventArgs e)
        {

        }
    }
}