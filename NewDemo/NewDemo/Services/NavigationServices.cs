using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NewDemo.Services
{
    class NavigationServices
    {
        public Task PushAsync(Page page) => GetCurrentNavigation().PushAsync(page);
        INavigation GetCurrentNavigation() => (Application.Current as App).MainPage.Navigation;
    }
}
