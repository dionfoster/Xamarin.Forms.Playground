using System.Windows.Input;
using FreshMvvm;
using Xamarin.Forms;

namespace XamarinFormsPlayground.NavigationProofs.PageModels
{
    public class ReusableFlow2PageModel : FreshBasePageModel
    {
        public ICommand GotoOriginCommand => new Command(async () => await CoreMethods.PushPageModel<ReusableFlow2PageModel>());
    }
}