using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Utility
{
    /// <summary>
    /// Math静态类
    /// </summary>
    public static class XOR
    {
        /// <summary>
        /// 以左侧的byte数组为主，与右侧的byte数组进行按位（由低位至高位）异或运算，并返回运算结果。
        /// 如果右侧的数组比左侧的数组长度小，则由低位至高位循环补充右侧数组，直至达到左侧数组长度。
        /// </summary>
        /// <param name="l">左侧的byte数组</param>
        /// <param name="r">右侧的byte数组</param>
        /// <returns>运算结果</returns>
        public static byte[] Run(byte[] l, byte[] r)
        {
            if (l == null || r == null) throw new ArgumentNullException();

            byte[] arr = new byte[l.Length];

            for (int i = 0; i < l.Length; i++)
            {
                int index = i % r.Length;

                arr[i] = Run(l[i], r[index]);
            }

            return arr;
        }

        /// <summary>
        /// 两个byte值的异或运算，并返回运算结果
        /// </summary>
        /// <param name="l">左侧byte</param>
        /// <param name="r">右侧byte</param>
        /// <returns>运算结果</returns>
        public static byte Run(byte l, byte r)
        {
            return (byte)(l ^ r);
        }
    }
}