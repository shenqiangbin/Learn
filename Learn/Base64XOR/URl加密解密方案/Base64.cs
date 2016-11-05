using System;
using System.Text;
using System.IO;

namespace UtilityCs
{
    public class Base64
    {
        /// <summary>
        /// Base64����
        /// </summary>
        /// <param name="codeName">���ܲ��õı��뷽ʽ</param>
        /// <param name="source">�����ܵ�����</param>
        /// <returns>����BASE64����������</returns>
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
        /// Base64���ܣ�����utf8���뷽ʽ����
        /// </summary>
        /// <param name="source">�����ܵ�����</param>
        /// <returns>���ܺ���ַ���</returns>
        public static string EncodeBase64(string source)
        {
            return EncodeBase64(Encoding.UTF8, source);
        }

        /// <summary>
        /// Base64����
        /// </summary>
        /// <param name="source">�����ܵ�����</param>
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
        /// Base64����
        /// </summary>
        /// <param name="codeName">���ܲ��õı��뷽ʽ��ע��ͼ���ʱ���õķ�ʽһ��</param>
        /// <param name="result">�����ܵ�����</param>
        /// <returns>���ܺ���ַ���</returns>
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
        /// Base64���ܣ�����utf8���뷽ʽ����
        /// </summary>
        /// <param name="result">�����ܵ�����</param>
        /// <returns>���ܺ���ַ���</returns>
        public static string DecodeBase64(string result)
        {
            return DecodeBase64(Encoding.UTF8, result);
        }

        /// <summary>
        /// Base64����
        /// </summary>
        /// <param name="result">�����ܵ�����</param>
        /// <returns>���ܺ���ֽ�����</returns>
        public static byte[] DecodeBase64ToByte(string result)
        {
            return System.Convert.FromBase64String(result);            
        }
    }
}