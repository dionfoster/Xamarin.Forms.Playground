using System.Windows.Input;
using FreshMvvm;
using Xamarin.Forms;

namespace XamarinFormsPlayground.NavigationProofs.PageModels
{
    public class SecondHomePageModel : FreshBasePageModel
    {
        public ICommand NextCommand => new Command(async () => await CoreMethods.PushPageModel<SecondHomeNav1PageModel>());
    }
}