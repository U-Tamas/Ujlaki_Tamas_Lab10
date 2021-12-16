using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Ujlaki_Tamas_Lab10.Data;
using System.IO;

namespace Ujlaki_Tamas_Lab10
{
    public partial class App : Application
    {
        static ShopListDatabase database;
        public static ShopListDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new
                   ShopListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ShopList.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new ListEntryPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
