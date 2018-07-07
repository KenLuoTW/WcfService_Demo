using System;
using System.ServiceModel.Web;
using System.Windows;

namespace WcfService_Demo
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        WebServiceHost host;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            host = new WebServiceHost(typeof(Service1), new Uri("http://localhost:8000/"));
            host.Open();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            host.Close();
        }
    }
}
