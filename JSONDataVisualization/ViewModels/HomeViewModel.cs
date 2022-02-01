using DevExpress.Mvvm;

namespace JSONDataVisualization.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {

        private INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }

        public HomeViewModel() { }

        public void NavigateDetails()
        {
            NavigationService.Navigate("MainView");
        }
    }
}
