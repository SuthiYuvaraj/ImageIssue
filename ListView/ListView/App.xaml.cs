using ListView;

namespace ListView
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
                //new NavigationPage(new Menu());
        }
    }
}
