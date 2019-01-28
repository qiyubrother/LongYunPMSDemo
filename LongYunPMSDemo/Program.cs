using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NNHuman.PMS;

namespace LongYunPMSDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new FrmMain());

            return;

            // 接口测试
            #region 初始化
            var baseUrl = "http://117.78.35.234:8980/pmsweb/crsapi.svc";
            var partnerId = "test";
            var hotelCode = "dycxd";
            var pms = new LYPMS(baseUrl, partnerId, hotelCode);
            var rst = string.Empty;
            #endregion

            #region 获取服务器时间戳 Pass
            {
                rst = pms.Timestamp();
                Console.WriteLine($"Timestamp::");
                Console.WriteLine($"{rst}");
            }
            #endregion

            #region 预订查询 Pass
            {
                var name = "李毅";
                var mobile = "13810338990";
                var resvsum = "10498"; 
                rst = pms.Resvlist(name, mobile, resvsum);
                Console.WriteLine($"Resvlist::");
                Console.WriteLine($"{rst}");
            }
            {
                var name = "银卡测试";
                //var name = System.Web.HttpUtility.UrlEncode("李毅");
                var mobile = "13910338990";
                var resvsum = "10519";
                rst = pms.Resvlist(name, mobile, resvsum);
                Console.WriteLine($"Resvlist::");
                Console.WriteLine($"{rst}");
            }
            {
                var name = "预定测试";
                //var name = System.Web.HttpUtility.UrlEncode("李毅");
                var mobile = "18510338990";
                var resvsum = "10519";
                rst = pms.Resvlist(name, mobile, resvsum);
                Console.WriteLine($"Resvlist::");
                Console.WriteLine($"{rst}");
            }
            #endregion

            #region 押金/支付  NoPass
            if (false)
            {
                var acctnum = "10519"; // "10498";
                var paytype = "0";
                var payamt = "-1200";
                // 0300 支付宝
                // 0301 微信
                var paycode = "0300";
                var payinfo = "支付宝";
                rst = pms.Paydeposit(acctnum, paytype, payamt, paycode, payinfo);

                Console.WriteLine($"GetPaydeposit::");
                Console.WriteLine($"{rst}");
            }
            #endregion

            #region 预订开房
            if (false)
            {
                var acctnum = "10552";
                var resvCheckin = new ResvCheckin();
                var checkinItem = new ResvCheckinItem();
                checkinItem.GuestId = 173433; // 预定查询的m_Item1数据项
                checkinItem.GuestInfo = new GuestInfo
                {
                    Name = "预定测试",
                    CertNum = "110226198308281416",
                    CertType ="11",
                    Gender = 1,
                    Nationality = string.Empty,
                    Birthday = string.Empty,
                    Address = string.Empty,
                    Country = string.Empty,
                    ValidTime = string.Empty,
                    Picture = string.Empty
                };
                resvCheckin.guestinfo[0] = checkinItem;
                rst = pms.Resvcheckin(acctnum, resvCheckin);

                Console.WriteLine($"Resvcheckin::");
                Console.WriteLine($"{rst}");
            }
            #endregion
            
            #region 上传房卡信息 Pass
            if (false)
            {
                var acctnum = "10552";
                var keynum = "0101";
                rst = pms.UploadRMKey(acctnum, keynum);

                Console.WriteLine($"UploadrMKey::");
                Console.WriteLine($"{rst}");
            }
            #endregion

            #region 查询在店客人账号 Pass
            if (false)
            {
                var roomnum = "907";
                var mobile = "13910338990";
                var certnum = "";
                rst = pms.GetAccnum(roomnum, mobile, certnum);

                Console.WriteLine($"GetAccnum::");
                Console.WriteLine($"{rst}");
            }
            #endregion

            #region 获取结账账单
            if (false)
            {
                var acctnum = "10552";
                rst = pms.GetcheckoutFolio(acctnum);

                Console.WriteLine($"GetcheckoutFolio::");
                Console.WriteLine($"{rst}");
            }
            #endregion

            #region 结账
            {
                var acctnum = "10552";
                rst = pms.Checkout(acctnum);

                Console.WriteLine($"Checkout::");
                Console.WriteLine($"{rst}");
            }
            #endregion

            Console.ReadKey(true);
        }
    }
}
