using Xamarin.Forms;

namespace XamarinFormsPlayground.Pages
{
    public class BasePage : ContentPage
    {
        public BasePage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override void OnAppearing()
        {
            this.Padding = Device.OnPlatform(
                iOS: new Thickness(0, 20, 0, 0),
                Android: new Thickness(0),
                WinPhone: new Thickness(0));

            base.OnAppearing();
        }
    }
}