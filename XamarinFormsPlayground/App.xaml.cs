using FreshMvvm;
using Xamarin.Forms;
using XamarinFormsPlayground.PageModels;

namespace XamarinFormsPlayground
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var page = FreshPageModelResolver.ResolvePageModel<LandingPageModel>();

            MainPage = new FreshNavigationContainer(page);
        }
    }
}
