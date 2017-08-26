using FresscoLabs.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FresscoLabs
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            SetMainPage();
        }

        public static void SetMainPage()
        {
            //Current.MainPage = new TabbedPage
            //{
            //    Children =
            //    {
            //        new NavigationPage(new ItemsPage())
            //        {
            //            Title = "Browse",
            //            Icon = Device.OnPlatform("tab_feed.png",null,null)
            //        },
            //        new NavigationPage(new AboutPage())
            //        {
            //            Title = "About",
            //            Icon = Device.OnPlatform("tab_about.png",null,null)
            //        },
            //        new NavigationPage(new HomePage())
            //        {
            //            Title = "Home",
            //            Icon = Device.OnPlatform("tab_feed.png",null,null)
            //        }
            //    }
            //};


            //Current.MainPage = new NavigationPage(new StartPage { Title = "Home" });
            Current.MainPage = new FresscoMasterDetailPage(); //new MyCarousel();
        }
    }
}
