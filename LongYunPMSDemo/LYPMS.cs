using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Security.Cryptography;

namespace LongYunPMSDemo
{
    public class LYPMS 
    {
        
        public LYPMS(string baseURL, string partnerId, string hotelCode)
        {
            BaseUrl = baseURL;
            HotelCode = hotelCode;
            PartnerId = partnerId;
        }

        #region 获取服务器时间戳 Get
        public string Timestamp()
        {
            return GetResponse($"{BaseUrl}/timestamp");

            //using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            //{
            //    string json = new JavaScriptSerializer().Serialize(new
            //    {
            //        user = "Foo",
            //        password = "Baz"
            //    });

            //    streamWriter.Write(json);
            //}
        }
        #endregion

        #region 预订查询 Get
        public string Resvlist(string name, string mobile, string resvnum)
        {
            var timestamp = GetTimestamp();
            var url = $"{BaseUrl}/resvlist?partner_id={PartnerId}&hotel_code={HotelCode}&timestamp={timestamp}&secret={Secret(timestamp)}&name={name}&mobile={mobile}&resvnum={resvnum}";

            return GetResponse(url);
        }
        #endregion

        #region 押金/支付 Get
        public string Paydeposit(string acctnum, string paytype, string payamt, string paycode, string payinfo)
        {
            var timestamp = GetTimestamp();
            var url = $"{BaseUrl}/paydeposit?partner_id={PartnerId}&hotel_code={HotelCode}&timestamp={timestamp}&secret={Secret(timestamp)}&acctnum={acctnum}&payamt={payamt}&paycode={paycode}&payinfo={payinfo}&paytype={paytype}";
            return GetResponse(url);
        }
        #endregion

        #region 预订开房 Post
        public string Resvcheckin(string acctnum, ResvCheckin resvCheckin)
        {
            var timestamp = GetTimestamp();
            var url = $"{BaseUrl}/resvcheckin?partner_id={PartnerId}&hotel_code={HotelCode}&timestamp={timestamp}&secret={Secret(timestamp)}&acctnum={acctnum}";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/json";
            request.Method = "POST";

            //File.AppendAllLines(@"d:\debug.txt", new[] {"URL::", url, string.Empty });

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(resvCheckin);
                //File.AppendAllLines(@"d:\debug.txt", new[] { "POST BODY JSON::", json, string.Empty });
                streamWriter.Write(json);
            }

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var rst = streamReader.ReadToEnd();
                //File.AppendAllLines(@"d:\debug.txt", new[] { "Result::", rst, string.Empty });
                return rst;
            }
        }
        #endregion

        #region 上传房卡信息 Get
        public string UploadRMKey(string acctnum, string keynum)
        {
            var timestamp = GetTimestamp();
            var url = $"{BaseUrl}/uploadrmkey?partner_id={PartnerId}&hotel_code={HotelCode}&timestamp={timestamp}&secret={Secret(timestamp)}&acctnum={acctnum}&keynum={keynum}";
            return GetResponse(url);
        }
        #endregion

        #region 查询在店客人账号 Get
        public string GetAccnum(string roomnum, string mobile, string certnum)
        {
            var timestamp = GetTimestamp();
            var url = $"{BaseUrl}/getaccnumtbyrm?partner_id={PartnerId}&hotel_code={HotelCode}&timestamp={timestamp}&secret={Secret(timestamp)}&roomnum={roomnum}&mobile={mobile}&certnum={certnum}";
            return GetResponse(url);
        }
        #endregion

        #region 获取结账账单 Get
        public string GetcheckoutFolio(string acctnum)
        {
            var timestamp = GetTimestamp();
            var url = $"{BaseUrl}/getcheckoutfolio?partner_id={PartnerId}&hotel_code={HotelCode}&timestamp={timestamp}&secret={Secret(timestamp)}&acctnum={acctnum}";
            return GetResponse(url);
        }
        #endregion

        #region 结账 Get
        public string Checkout(string acctnum)
        {
            var timestamp = GetTimestamp();
            var url = $"{BaseUrl}/checkout?partner_id={PartnerId}&hotel_code={HotelCode}&timestamp={timestamp}&secret={Secret(timestamp)}&acctnum={acctnum}";
            return GetResponse(url);
        }
        #endregion

        //private Func<DateTime, string> DateTimeToTimeStamp = (dateTime) =>
        //{
        //    var startTime = TimeZoneInfo.ConvertTime(new System.DateTime(1970, 1, 1), TimeZoneInfo.Local);
        //    return ((long)(dateTime - startTime).TotalSeconds).ToString(); // 相差秒数
        //};

        public string GetTimestamp()
        {
            return Timestamp().Replace("\"", string.Empty);
        }

        private Func<string, string, string, string> ShA1 = (partnerId, hotelCode, timestamp) =>
        {
            var input = Encoding.UTF8.GetBytes($"{partnerId}~{hotelCode}~{timestamp}");
            SHA1 sha = new SHA1CryptoServiceProvider();
            var outputBytes = sha.ComputeHash(input);

            var sb = new StringBuilder();
            foreach (byte iByte in outputBytes)
            {
                sb.AppendFormat("{0:x2}", iByte);
            }

            return sb.ToString();
        };

        private Func<string, string> GetResponse = (url) =>
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/json";
            request.Method = "GET";
            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                return streamReader.ReadToEnd();
            }
        };

        private string Secret(string timestamp)
        { 
            return ShA1(PartnerId, HotelCode, timestamp);
        }

        public string BaseUrl { private set; get; }
        public string HotelCode { private set; get; }
        public string PartnerId { private set; get; }
    }
    [Serializable]
    public class ResvCheckin
    {
        [JsonProperty("guestinfo")]
        public ResvCheckinItem[] guestinfo = new ResvCheckinItem[1];
    }

    [Serializable]
    public class ResvCheckinItem
    {
        [JsonProperty("GuestId")]
        public int GuestId { get; set; }
        [JsonProperty("GuestInfo")]
        public GuestInfo GuestInfo { get; set; }
    }

    [Serializable]
    public class GuestInfo
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("Name")]
        public string Name { get; set; }
        /// <summary>
        /// 证件号
        /// </summary>
        [JsonProperty("CertNum")]
        public string CertNum { get; set; }
        /// <summary>
        /// 证件类型
        /// </summary>
        [JsonProperty("CertType")]
        public string CertType { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        [JsonProperty("Gender")]
        public int? Gender { get; set; }
        /// <summary>
        /// 民族名称
        /// </summary>
        [JsonProperty("Nationality")]
        public string Nationality { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        [JsonProperty("Birthday")]
        public string Birthday { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        [JsonProperty("Address")]
        public string Address { get; set; }
        /// <summary>
        /// 国籍代码
        /// </summary>
        [JsonProperty("Country")]
        public string Country { get; set; }
        /// <summary>
        /// 证件有效期
        /// </summary>
        [JsonProperty("ValidTime")]
        public string ValidTime { get; set; }

        /// <summary>
        /// 证件照
        /// </summary>
        [JsonProperty("Picture")]
        public string Picture { get; set; }
    }
}
