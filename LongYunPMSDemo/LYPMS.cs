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
            var url = $"{BaseUrl}/timestamp";
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Content-Type", "application/json");
                var response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var myResponseStream = response.Content.ReadAsStreamAsync().Result;
                    var myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                    var rst = myStreamReader.ReadToEnd();
                    myStreamReader.Close();
                    myResponseStream.Close();

                    return rst;
                }
                else
                {
                    // 读取失败
                    return string.Empty;
                }
            }
        }
        #endregion

        #region 预订查询 Get
        public string Resvlist(string name, string mobile, string resvnum)
        {
            var timestamp = DateTimeToTimeStamp(DateTime.Now);
            var url = $"{BaseUrl}/resvlist?partner_id={PartnerId}&hotel_code={HotelCode}&timestamp={timestamp}&secret={Secret(timestamp)}&name={name}&mobile={mobile}&resvnum={resvnum}";
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Content-Type", "application/json");
                var response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var myResponseStream = response.Content.ReadAsStreamAsync().Result;
                    var myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                    var rst = myStreamReader.ReadToEnd();
                    myStreamReader.Close();
                    myResponseStream.Close();

                    return rst;
                }
                else
                {
                    // 读取失败
                    return string.Empty;
                }
            }
        }
        #endregion

        #region 押金/支付 Get
        public string Paydeposit(string acctnum, string paytype, string payamt, string paycode, string payinfo)
        {
            var timestamp = DateTimeToTimeStamp(DateTime.Now);
            var url = $"{BaseUrl}/paydeposit?partner_id={PartnerId}&hotel_code={HotelCode}&timestamp={timestamp}&secret={Secret(timestamp)}&acctnum={acctnum}&payamt={payamt}&paycode={paycode}&payinfo={payinfo}&paytype={paytype}";
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Content-Type", "application/json");
                var response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var myResponseStream = response.Content.ReadAsStreamAsync().Result;
                    var myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                    var rst = myStreamReader.ReadToEnd();
                    myStreamReader.Close();
                    myResponseStream.Close();

                    return rst;
                }
                else
                {
                    // 读取失败
                    return string.Empty;
                }
            }
        }
        #endregion

        #region 预订开房 Post
        public string Resvcheckin(string acctnum, ResvCheckin resvCheckin)
        {
            var timestamp = DateTimeToTimeStamp(DateTime.Now);
            var url = $"{BaseUrl}/resvcheckin?partner_id={PartnerId}&hotel_code={HotelCode}&timestamp={timestamp}&secret={Secret(timestamp)}&acctnum={acctnum}";
            using (var client = new HttpClient())
            {
                //client.DefaultRequestHeaders.Add("Content-Type", "application/json");

                var str = JsonConvert.SerializeObject(resvCheckin);
                HttpContent content = new StringContent(str);
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                var response = client.PostAsync(url, content).Result;
                if (response.IsSuccessStatusCode)
                {
                    var myResponseStream = response.Content.ReadAsStreamAsync().Result;
                    var myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                    var rst = myStreamReader.ReadToEnd();
                    myStreamReader.Close();
                    myResponseStream.Close();

                    return rst;
                }
                else
                {
                    // 读取失败
                    return string.Empty;
                }
            }
        }
        #endregion

        #region 上传房卡信息 Get
        public string UploadrMKey(string acctnum, string keynum)
        {
            var timestamp = DateTimeToTimeStamp(DateTime.Now);
            var url = $"{BaseUrl}/uploadrmkey?partner_id={PartnerId}&hotel_code={HotelCode}&timestamp={timestamp}&secret={Secret(timestamp)}&acctnum={acctnum}&keynum={keynum}";
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Content-Type", "application/json");
                var response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var myResponseStream = response.Content.ReadAsStreamAsync().Result;
                    var myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                    var rst = myStreamReader.ReadToEnd();
                    myStreamReader.Close();
                    myResponseStream.Close();

                    return rst;
                }
                else
                {
                    // 读取失败
                    return string.Empty;
                }
            }
        }
        #endregion

        #region 查询在店客人账号 Get
        public string GetAccnum(string roomnum, string mobile, string certnum)
        {
            var timestamp = DateTimeToTimeStamp(DateTime.Now);
            var url = $"{BaseUrl}/getaccnumtbyrm?partner_id={PartnerId}&hotel_code={HotelCode}&timestamp={timestamp}&secret={Secret(timestamp)}&roomnum={roomnum}&mobile={mobile}&certnum={certnum}";
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Content-Type", "application/json");
                var response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var myResponseStream = response.Content.ReadAsStreamAsync().Result;
                    var myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                    var rst = myStreamReader.ReadToEnd();
                    myStreamReader.Close();
                    myResponseStream.Close();

                    return rst;
                }
                else
                {
                    // 读取失败
                    return string.Empty;
                }
            }
        }
        #endregion

        #region 获取结账账单 Get
        public string GetcheckoutFolio(string acctnum)
        {
            var timestamp = DateTimeToTimeStamp(DateTime.Now);
            var url = $"{BaseUrl}/getcheckoutfolio?partner_id={PartnerId}&hotel_code={HotelCode}&timestamp={timestamp}&secret={Secret(timestamp)}&acctmnum={acctnum}";
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Content-Type", "application/json");
                var response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var myResponseStream = response.Content.ReadAsStreamAsync().Result;
                    var myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                    var rst = myStreamReader.ReadToEnd();
                    myStreamReader.Close();
                    myResponseStream.Close();

                    return rst;
                }
                else
                {
                    // 读取失败
                    return string.Empty;
                }
            }
        }
        #endregion

        #region 结账 Get
        public string Checkout(string acctnum)
        {
            var timestamp = DateTimeToTimeStamp(DateTime.Now);
            var url = $"{BaseUrl}/checkout?partner_id={PartnerId}&hotel_code={HotelCode}&timestamp={timestamp}&secret={Secret(timestamp)}&acctmnum={acctnum}";
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Content-Type", "application/json");
                var response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var myResponseStream = response.Content.ReadAsStreamAsync().Result;
                    var myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                    var rst = myStreamReader.ReadToEnd();
                    myStreamReader.Close();
                    myResponseStream.Close();

                    return rst;
                }
                else
                {
                    // 读取失败
                    return string.Empty;
                }
            }
        }
        #endregion

        private Func<DateTime, string> DateTimeToTimeStamp = (dateTime) =>
        {
            var startTime = TimeZoneInfo.ConvertTime(new System.DateTime(1970, 1, 1), TimeZoneInfo.Local);
            return ((long)(dateTime - startTime).TotalSeconds).ToString(); // 相差秒数
        };

        private Func<string, string, string, string> ShA1 = (partnerId, hotelCode, timestamp) =>
        {
            var input = Encoding.UTF8.GetBytes($"{partnerId}~{hotelCode}~{timestamp}");
            SHA1 sha = new SHA1CryptoServiceProvider();
            var output = Encoding.UTF8.GetString(sha.ComputeHash(input));

            return output;
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
