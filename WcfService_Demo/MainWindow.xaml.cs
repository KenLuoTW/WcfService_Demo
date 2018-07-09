using System;
using System.Collections.Generic;
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
            Service1.label1 = this.label1;
            Service1.songlist = songlist;
            host.Open();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            host.Close();
        }

        public static List<string> songlist = new List<string>()
        {
            "101753|國語|女歌星|吳佩慈|閃著淚光的決定[滾石]",
            "125575|國語|團體|法蘭黛樂團|閃電 [瑞影]",
            "122264|國語|團體|M3|閃電[弘音](music)",
            "117118|國語|團體|四分衛|閃電[揚聲]",
            "202845|台語|女歌星|徐紫淇|閃辣閃辣[音圓]",
            "204304|台語|女歌星|葉璦菱|閃爍的天星[美華]",
            "204305|台語|女歌星|葉璦菱|閃爍的天星[乾坤]",
            "300633|粵語|女歌星|楊千嬅|閃靈[新藝寶+加州紅]",
            "205006|台語|女歌星|蔡秋鳳|陣陣的腳步聲[你歌]",
            "204858|台語|女歌星|劉俐婷|陣陣風雨[美華]"
        };

    }
}
