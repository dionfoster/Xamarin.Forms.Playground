using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using FreshMvvm;
using System.Windows.Input;
using Akavache;
using Xamarin.Forms;

namespace XamarinFormsPlayground.PageModels
{
    public class ListingPageModel : FreshBasePageModel
    {
        public List<SaveableItem> SavedItems { get; set; }
        public ICommand AddCommand => new Command(async () => await CoreMethods.PushPageModel<ItemPageModel>());
        public ICommand EditItemCommand => new Command(async x => await CoreMethods.PushPageModel<ItemPageModel>(x));
        public ICommand RemoveItemCommand => new Command(RemoveItem);

        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);

            GetAllItems();
        }

        private void GetAllItems()
        {
            BlobCache.UserAccount.GetAllObjects<SaveableItem>()
                .Subscribe(x => SavedItems = x.ToList(), x => Debug.WriteLine("Got them all!"));
        }

        private void RemoveItem(object o)
        {
            var item = (SaveableItem) o;

            BlobCache.UserAccount.Invalidate($"Item-{item.Name}").Subscribe(x => { }, GetAllItems);
        }
    }
}