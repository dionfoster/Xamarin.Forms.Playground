using System;
using Xamarin.Forms;

namespace XamarinFormsPlayground
{
    public partial class AlternateBackgroundImageLayout : ContentPage
    {
        public AlternateBackgroundImageLayout()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
