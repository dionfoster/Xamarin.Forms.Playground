using System.Windows.Input;
using FreshMvvm;
using PropertyChanged;
using Xamarin.Forms;

namespace XamarinFormsPlayground.PageModels
{
    [ImplementPropertyChanged]
    public class AlternateBackgroundImagePageModel : FreshBasePageModel
    {
        public ICommand BackCommand
        {
            get
            {
                return new Command(async () => await CoreMethods.PopPageModel());
            }
        }

        public string Title { get; set; }

        public AlternateBackgroundImagePageModel()
        {
            Title = "The Landing Page!";
        }
    }
}