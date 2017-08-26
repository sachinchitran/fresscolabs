using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FresscoLabs.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Load : ContentPage
    {
        ObservableCollection<FrescoItems> perishableItems = new ObservableCollection<FrescoItems>();
        public Load()
        {
            InitializeComponent();

            perishableItems.Add(new FrescoItems { ItemName = "Tomato", ItemMalName = "(തക്കാളി)", ItemImagePath = "p1.jpg" });
            perishableItems.Add(new FrescoItems { ItemName = "Apple", ItemMalName = "(ആപ്പിൾ യു എസ് എ)", ItemImagePath = "p2.jpg" });
            perishableItems.Add(new FrescoItems { ItemName = "Onion", ItemMalName = "(ഉള്ളി )", ItemImagePath = "p3.jpg" });
            perishableItems.Add(new FrescoItems { ItemName = "Potato", ItemMalName = "(ഉരുളക്കിഴങ്ങ്)", ItemImagePath = "p4.jpg" });
            perishableItems.Add(new FrescoItems { ItemName = "Carrot", ItemMalName = "(കാരറ്റ്)", ItemImagePath = "p5.jpg" });

            listBestSellers.ItemsSource = perishableItems;
        }
    }

    public class FrescoItems
    {
        public string ItemName { get; set; }
        public string ItemMalName { get; set; }
        public string ItemImagePath { get; set; }

    }
}