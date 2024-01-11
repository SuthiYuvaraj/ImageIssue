namespace ListView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void DeleteVoiceRecord_Tapped(object sender, TappedEventArgs e)
        {
            DisplayAlert("Tap", "Image Tapped", "Ok");
        }
    }

}
