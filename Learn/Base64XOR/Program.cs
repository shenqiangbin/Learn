using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base64XOR
{
    class Program
    {
        static void Main(string[] args)
        {
            //对URL进行先进行【异或】加密，然后进行Base64加密

        }

        static void Apply1()
        {
            //            操作步骤：

            //           1.在xml文件中引进js

            //              < script src = "../JScript/JSEncode.js" type = "text/javascript" ></ script >

            //          2.在 js 中对URL 进行加密

            //              var query = base64encode_utf8("ApprovalObjID=" + currentSelectedGroup + "&TargetPath=" + targetPath + "&Type=" + ApprovalType);
            //              var url = "CreateModeSelector.aspx?" + query; （这里好的做法是赋值一个key，在后台通过使用key来取值）

            //          3.在使用页面中队URL解密

            //            URL解密            
            //              string query = Request.Url.Query.Substring(1, Request.Url.Query.Length - 1);
            //              var baseDecode = UtilityCs.Base64.DecodeBase64(Encoding.UTF8, query);
            //              var nameValueCollection = HttpUtility.ParseQueryString(
            //              Encoding.UTF8.GetString(UtilityCs.Math.XOR(Encoding.UTF8.GetBytes(baseDecode), Encoding.UTF8.GetBytes(Common.Entity.Session.Current.Id.ToString()))),
            //              Encoding.UTF8);


        }
    }
}
