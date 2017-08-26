using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FresscoLabs.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public Master()
        {
            InitializeComponent();

            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Contacts",
                IconSource = "menu1.png",
                TargetType = typeof(HomePage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "TodoList",
                IconSource = "menu2.png",
                TargetType = typeof(OurTabbledPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Reminders",
                IconSource = "menu3.png",
                TargetType = typeof(StartPage)
            });

            masterPageItems.Add(new MasterPageItem
            {
                Title = "Home",
                IconSource = "menu1.png",
                TargetType = typeof(Load)
            });

            listView.ItemsSource = masterPageItems;
        }
    }

    internal class MasterPageItem
    {
        public string Title { get; set; }
        public string IconSource { get; set; }
        public Type TargetType { get; set; }
    }
}