using System.Windows.Input;
using FreshMvvm;
using Xamarin.Forms;

namespace XamarinFormsPlayground.NavigationProofs.PageModels
{
    public class ReusableFlow1PageModel : FreshBasePageModel
    {
        public ICommand GotoReusableFlow2Command => new Command(async () => await CoreMethods.PushPageModel<ReusableFlow2PageModel>());
    }
}