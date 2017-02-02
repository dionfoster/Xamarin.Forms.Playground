using System.Windows.Input;
using FreshMvvm;
using Xamarin.Forms;

namespace XamarinFormsPlayground.NavigationProofs.PageModels
{
    public class Nav3PageModel : FreshBasePageModel
    {
        public ICommand NextCommand => new Command(async () => await CoreMethods.PushPageModel<SecondHomePageModel>());
    }
}