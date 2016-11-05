using System;
using System.Text;
using System.IO;

namespace UtilityCs
{
    public class Base64
    {
        /// <summary>
        /// Base64加密
        /// </summary>
        /// <param name="codeName">加密采用的编码方式</param>
        /// <param name="source">待加密的明文</param>
        /// <returns>返回BASE64编码后的数据</returns>
        public static string EncodeBase64(Encoding encode, string source)
        {
            byte[] bytes = encode.GetBytes(source);
            string resaultOfTransform = string.Empty;
            try
            {
                resaultOfTransform = System.Convert.ToBase64String(bytes);
            }
            catch
            {
                resaultOfTransform = source;
            }
            return resaultOfTransform;
        }

        /// <summary>
        /// Base64加密，采用utf8编码方式加密
        /// </summary>
        /// <param name="source">待加密的明文</param>
        /// <returns>加密后的字符串</returns>
        public static string EncodeBase64(string source)
        {
            return EncodeBase64(Encoding.UTF8, source);
        }

        /// <summary>
        /// Base64加密
        /// </summary>
        /// <param name="source">待加密的明文</param>
        /// <returns></returns>
        public static string EncodeBase64(byte[] source)
        {
            string resaultOfTransform = string.Empty;
            try
            {
                resaultOfTransform = System.Convert.ToBase64String(source);
            }
            catch
            {
                resaultOfTransform = source.ToString();
            }
            return resaultOfTransform;
        }

        /// <summary>
        /// Base64解密
        /// </summary>
        /// <param name="codeName">解密采用的编码方式，注意和加密时采用的方式一致</param>
        /// <param name="result">待解密的密文</param>
        /// <returns>解密后的字符串</returns>
        public static string DecodeBase64(Encoding encode, string result)
        {
            string decode = "";
            byte[] bytes = System.Convert.FromBase64String(result);
            try
            {
                decode = encode.GetString(bytes);
            }
            catch
            {
                decode = result;
            }
            return decode;
        }

        /// <summary>
        /// Base64解密，采用utf8编码方式解密
        /// </summary>
        /// <param name="result">待解密的密文</param>
        /// <returns>解密后的字符串</returns>
        public static string DecodeBase64(string result)
        {
            return DecodeBase64(Encoding.UTF8, result);
        }

        /// <summary>
        /// Base64解密
        /// </summary>
        /// <param name="result">待解密的密文</param>
        /// <returns>解密后的字节数组</returns>
        public static byte[] DecodeBase64ToByte(string result)
        {
            return System.Convert.FromBase64String(result);            
        }
    }
}