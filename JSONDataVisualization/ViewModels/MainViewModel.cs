using DevExpress.Mvvm;
using System;
using System.Windows.Input;

namespace JSONDataVisualization.ViewModels
{

    public class MainViewModel : ViewModelBase
    {
        public ICommand OnViewLoadedCommand { get; private set; }
        

        public INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }

        public MainViewModel()
        {
            OnViewLoadedCommand = new DelegateCommand(OnViewLoaded);
        }

        public void OnViewLoaded()
        {
            NavigationService.Navigate("HomeView", null, this);
        }
    }
}
