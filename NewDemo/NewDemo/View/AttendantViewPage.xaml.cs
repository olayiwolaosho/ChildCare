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
    public partial class AttendantViewPage : ContentPage
    {
        public AttendantViewPage()
        {
            InitializeComponent();
        }

        private void AttedndantView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}