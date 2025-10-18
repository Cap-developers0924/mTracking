namespace MTrackingApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnSleep()
        {
            base.OnSleep();
#if ANDROID
            var cookiemanager = Android.Webkit.CookieManager.Instance;
            cookiemanager.RemoveAllCookies(null);
            cookiemanager.Flush();
#endif
        }
    }
}
