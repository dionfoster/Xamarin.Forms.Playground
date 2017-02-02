using System.Windows.Input;
using FreshMvvm;
using Xamarin.Forms;

namespace XamarinFormsPlayground.PageModels
{
    public class LandingPageModel : FreshBasePageModel
    {
        public ICommand NextCommand => new Command(async () => await CoreMethods.PushPageModel<AlternateBackgroundImagePageModel>());
    }
}