using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.ServiceModel.Web;
using System.Text;
using System.Windows.Controls;

namespace WcfService_Demo
{
    // 注意: 您可以使用 [重構] 功能表上的 [重新命名] 命令同時變更程式碼和組態檔中的類別名稱 "Service1"。
    public class Service1 : IService1
    {
        public static Label label1 { get; set; }
        public static List<string> songlist { get; set; }

        public Stream QuerySong(string lang, string singer, string words, string condition, int page, int rows, string sort)
        {
            label1.Content = (condition != null && condition != "") ? "狀態: 查詢歌曲(" + condition + ")" : "狀態: 無";
            string text = (condition != null && condition != "") ? JsonConvert.SerializeObject(songlist, Formatting.None) : "[]";
            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes(text));
        }

        public Stream QuerySinger(string condition, int page, int rows, string sort)
        {
            label1.Content = (condition != null && condition != "") ? "狀態: 查詢歌手(" + condition + ")" : "狀態: 無";
            string text = "{\"Singer_Name\":\"AKI黃淑惠\",\"Singer_Type\":1,\"Singer_Strokes\":1}";
            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes(text));
        }

        public Stream DoCrazyKTV_Action(string value, string state)
        {
            label1.Content = "狀態: 點歌功能(切歌)";
            string text = "{\"點歌功能\":\"切歌\"}";
            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes(text));
        }

        public Stream DoCrazyKTV_Control(int value, string state)
        {
            label1.Content = "狀態: 播放控制(靜音)";
            string text = "{\"播放控制\":\"靜音\"}";
            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes(text));
        }
    }
}
