using Xamarin.Forms;

namespace Lab10
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ViewToViewDemo();
            //MainPage = new BindingModeDemo();
            //MainPage = new ListViewDemo();
            //MainPage = new PickerDemo();

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
