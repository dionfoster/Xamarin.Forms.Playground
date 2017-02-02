using System.Windows.Input;
using FreshMvvm;
using Xamarin.Forms;
using XamarinFormsPlayground.NavigationProofs.PageModels;

namespace XamarinFormsPlayground.PageModels
{
    public class LandingPageModel : FreshBasePageModel
    {
        public ICommand NextCommand => new Command(async () => await CoreMethods.PushPageModel<AlternateBackgroundImagePageModel>());
        public ICommand StartNavigationCommand => new Command(async () => await CoreMethods.PushPageModel<Nav1PageModel>());
    }
}