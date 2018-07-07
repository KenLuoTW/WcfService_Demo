using System.IO;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService_Demo
{
    // 注意: 您可以使用 [重構] 功能表上的 [重新命名] 命令同時變更程式碼和組態檔中的類別名稱 "Service1"。
    public class Service1 : IService1
    {
        public Stream QuerySong(string lang, string singer, string words, string condition, int page, int rows, string sort)
        {
            string text = (condition != null) ? "{\"Song_Id\": 10015,\"Song_SongName\": \"Flow[揚聲]\",\"Song_Singer\": \"方大同 & 王力宏\",\"Song_WordCount\": 1,\"Song_Lang\": \"國語\",\"Song_SongStroke\": 1}" : "[]";
            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes(text));
        }

        public Stream QuerySinger(string condition, int page, int rows, string sort)
        {
            string text = "{\"Singer_Name\":\"AKI黃淑惠\",\"Singer_Type\":1,\"Singer_Strokes\":1}";
            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes(text));
        }

        public Stream DoCrazyKTV_Action(string value, string state)
        {
            string text = "{\"點歌功能\":\"切歌\"}";
            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes(text));
        }

        public Stream DoCrazyKTV_Control(int value, string state)
        {
            string text = "{\"播放控制\":\"靜音\"}";
            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes(text));
        }
    }
}
