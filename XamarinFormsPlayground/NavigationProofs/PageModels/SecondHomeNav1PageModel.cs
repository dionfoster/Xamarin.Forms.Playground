using System.Windows.Input;
using FreshMvvm;
using Xamarin.Forms;

namespace XamarinFormsPlayground.NavigationProofs.PageModels
{
    public class SecondHomeNav1PageModel : FreshBasePageModel
    {
        public ICommand GotoReusableFlow1Command => new Command(async () => await CoreMethods.PushPageModel<ReusableFlow1PageModel>());
    }
}