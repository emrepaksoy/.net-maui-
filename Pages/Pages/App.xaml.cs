namespace Pages
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navPage  = new NavigationPage(new MainPage());

            navPage.Background = Colors.Blue;
            navPage.BarTextColor = Colors.OrangeRed;

            MainPage = new TabbedPageDemo();
        }
    }
}
