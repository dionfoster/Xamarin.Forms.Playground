using System.Windows.Input;
using FreshMvvm;
using Xamarin.Forms;

namespace XamarinFormsPlayground.NavigationProofs.PageModels
{
    public class Nav2PageModel : FreshBasePageModel
    {
        public ICommand NextCommand => new Command(async () => await CoreMethods.PushPageModel<Nav3PageModel>());
        public ICommand GotoReusableFlow1Command => new Command(async () => await CoreMethods.PushPageModel<ReusableFlow1PageModel>());
    }
}