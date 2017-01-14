using System;
using Xamarin.Forms;

namespace XamarinFormsPlayground
{
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AlternateBackgroundImageLayout());
        }
    }
}
