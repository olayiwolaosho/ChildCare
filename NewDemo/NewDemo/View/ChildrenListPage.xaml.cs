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
    public partial class ChildrenListPage : ContentPage
    {
        public ChildrenListPage()
        {
            InitializeComponent();
        }

        private void ChildrenListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}