using Akavache;
using FreshMvvm;
using Xamarin.Forms;
using XamarinFormsPlayground.PageModels;

namespace XamarinFormsPlayground
{
    public partial class App : Application
    {
        public App()
        {
            BlobCache.ApplicationName = "AkavacheExperiment";

            var page = FreshPageModelResolver.ResolvePageModel<ListingPageModel>();

            MainPage = new FreshNavigationContainer(page);
        }
    }
}
