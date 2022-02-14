using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Aplus.Data;
using System.IO;

[assembly: ExportFont("MaterialIcons-Regular.ttf", Alias = "AplusFont")]
namespace Aplus
{
    public partial class App : Application
    {
        static ProjectDBClass projectDBClass;
        public static ProjectDBClass ProjectDBClass
        {
            get
            {
                if (projectDBClass == null)
                {
                    projectDBClass = new ProjectDBClass(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ProjecttsDatabase.db3"));
                }
                return projectDBClass;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new AuthorizationPage());
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
