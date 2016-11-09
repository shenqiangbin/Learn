using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlGenerator
{
    /// <summary>
    /// 生成随机数字
    /// </summary>
    public class NumberRandomValue : RandomValues
    {
        private int max;
        private int min;
        private Random randomer;

        public NumberRandomValue(int min, int max)
            : this(min, max, false)
        { }

        /// <summary>
        /// 全包含
        /// </summary>
        /// <param name="max">最小值</param>
        /// <param name="min">最大值</param>
        public NumberRandomValue(int min, int max, bool isNll)
        {
            this.max = max;
            this.min = min;
            this.isNull = isNull;
            this.randomer = new Random();
        }

        public override object Generate()
        {
            if (this.isNull && randomer.Next(0, 10) % 3 == 0)
            {
                if (WithQuotation)
                    return "";
                else
                    return "null";
            }

            return randomer.Next(min, max + 1);
        }
    }
}
