using NewDemo.Model;
using NewDemo.Services;
using NewDemo.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NewDemo.ViewModel.ChildViewModel
{
    public sealed class ChildrenListViewModel : BaseViewModel
    {
        public IDatastore<RegisterChildren> datastore => DependencyService.Get<IDatastore<RegisterChildren>>();


        ObservableCollection<RegisterChildren> _registerAllChildren;
        public ObservableCollection<RegisterChildren> RegisterAllChildren
        {
            get => _registerAllChildren;
            set => SetProperty(ref _registerAllChildren, RegisterAllChildren);
        }

        public async Task<ChildrenListViewModel> PopulateListView()
        {
            _registerAllChildren = new ObservableCollection<RegisterChildren>(await datastore.GettItemsAsync());
            return this;
        }

        public static Task<ChildrenListViewModel> CreateAsync()
        {
            var CLVM = new ChildrenListViewModel();
            return CLVM.PopulateListView();
        }
    }
}
