using NewDemo.ViewModel.ChildViewModel;
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
        ChildrenListViewModel CLVM => BindingContext as ChildrenListViewModel;
        public ChildrenListPage()
        {
            InitializeComponent();
            
        }

        protected async override void OnAppearing()
        {
            BindingContext = await ChildrenListViewModel.CreateAsync();
            base.OnAppearing();
        }

        private void ChildrenListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}