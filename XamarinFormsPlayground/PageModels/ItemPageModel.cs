using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Akavache;
using FreshMvvm;
using PropertyChanged;
using Xamarin.Forms;

namespace XamarinFormsPlayground.PageModels
{
    [ImplementPropertyChanged]
    public class ItemPageModel : FreshBasePageModel
    {
        public string Name { get; set; }
        public ICommand SaveCommand => new Command(async () => await SaveItem(), () => !string.IsNullOrEmpty(Name));

        public override void Init(object initData)
        {
            base.Init(initData);

            if (initData != null)
            {
                var item = (SaveableItem) initData;

                Name = item.Name;
            }
        }

        private async Task SaveItem()
        {
            await BlobCache.UserAccount.InsertObject($"Item-{Name}", new SaveableItem {Name = Name});

            await CoreMethods.PopPageModel();
        }
    }
}