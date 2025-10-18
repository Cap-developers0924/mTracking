namespace MTrackingApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MyWebView.Navigated += MyWebView_Navigated;
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            ShowWebView("https://www.caplog.co.in/VAuth/VAuth/VAuthIndex?source=mTracking");
        }

        private void OnTrackingClicked(object sender, EventArgs e)
        {
            ShowWebView("http://soft.vriddhilogitech.in:888");
        }

        //private void OnUploadPODClicked(object sender, EventArgs e)
        //{
        //    ShowWebView("https://www.caplog.co.in/VAuth/VAuth/VAuthIndex?source=");
        //}

        private void ShowWebView(string url)
        {
            LandingPageLayout.IsVisible = false;
            WebViewContainer.IsVisible = true;
            HomeButton.IsVisible = true;
            MyWebView.Source = url;
            ButtonRowDef.Height = new GridLength(50);
        }

        private void OnHomeClicked(object sender, EventArgs e)
        {
            WebViewContainer.IsVisible = false;
            LandingPageLayout.IsVisible = true;
            HomeButton.IsVisible = false;
            MyWebView.Source = null;
            ButtonRowDef.Height = new GridLength(0);
        }

        private void MyWebView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            if (e.Url != null && !e.Url.Contains("www.caplog.co.in/VAuth/VAuth/VAuthIndex")
                              && !e.Url.Contains("soft.vriddhilogitech.in:888"))
            {
                HomeButton.IsVisible = false;
                ButtonRowDef.Height = new GridLength(0);
            }
            else
            {
                HomeButton.IsVisible = true;
                ButtonRowDef.Height = new GridLength(50);
            }
        }
    }

}
