using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LongYunPMSDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 接口测试
            #region 初始化
            var baseUrl = "https://api.pms.com";
            var partnerId = "10001";
            var hotelCode = "2001";
            var pms = new LYPMS(baseUrl, partnerId, hotelCode);
            var rst = string.Empty;
            #endregion

            #region 获取服务器时间戳
            {
                rst = pms.Timestamp();
                Console.WriteLine($"Timestamp::");
                Console.WriteLine($"{rst}");
            }
            #endregion

            #region 预订查询
            {
                var name = "liuzhenhua";
                var mobile = "1324";
                var resvsum = "1000";
                rst = pms.Resvlist(name, mobile, resvsum);
                Console.WriteLine($"Resvlist::");
                Console.WriteLine($"{rst}");
            }
            #endregion

            #region 押金/支付
            {
                var acctnum = "1111";
                var paytype = "0";
                var payamt = "1200";
                var paycode = "YMX";
                var payinfo = "12DSFASD45S6DF2SFADF";
                rst = pms.Paydeposit(acctnum, paytype, payamt, paycode, payinfo);

                Console.WriteLine($"GetPaydeposit::");
                Console.WriteLine($"{rst}");
            }
            #endregion

            #region 预订开房
            {
                var acctnum = "1111";
                var checkin = new ResvCheckin
                {
                    Name = "Liuzhenhua",
                    CertNum = "110226",
                    Gender = null,
                    Nationality = string.Empty,
                    Birthday = string.Empty,
                    Address = string.Empty,
                    Country = string.Empty,
                    ValidTime = string.Empty,
                    Picture = string.Empty
                };
                rst = pms.Resvcheckin(acctnum, checkin);

                Console.WriteLine($"Resvcheckin::");
                Console.WriteLine($"{rst}");
            }
            #endregion

            #region 上传房卡信息
            {
                var acctnum = "1111";
                var keynum = "0";
                rst = pms.UploadrMKey(acctnum, keynum);

                Console.WriteLine($"UploadrMKey::");
                Console.WriteLine($"{rst}");
            }
            #endregion

            #region 查询在店客人账号
            {
                var roomnum = "1111";
                var mobile = "1324";
                var certnum = "";
                rst = pms.GetAccnum(roomnum, mobile, certnum);

                Console.WriteLine($"GetAccnum::");
                Console.WriteLine($"{rst}");
            }
            #endregion

            #region 获取结账账单
            {
                var acctnum = "1111";
                rst = pms.GetcheckoutFolio(acctnum);

                Console.WriteLine($"GetcheckoutFolio::");
                Console.WriteLine($"{rst}");
            }
            #endregion

            #region 结账
            {
                var acctnum = "1111";
                rst = pms.Checkout(acctnum);

                Console.WriteLine($"Checkout::");
                Console.WriteLine($"{rst}");
            }
            #endregion

            Console.ReadKey(true);
        }
    }
}
