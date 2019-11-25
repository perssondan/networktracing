using System.Net.Http;
using System.Windows;

namespace networktracing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void OnButtonClick(object sender, RoutedEventArgs e)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("http://www.google.com");
            }
        }
    }
}