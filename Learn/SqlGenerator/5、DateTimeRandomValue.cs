using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlGenerator
{
    public class DateTimeRandomValue : RandomValues
    {
        private DateTime maxDate;
        private int spanDays;
        private Random randomer = new Random();

        /// <summary>
        /// max与min的相差天数应小于Int32.MaxValue
        /// </summary>
        /// <param name="max"></param>
        /// <param name="min"></param>
        public DateTimeRandomValue(DateTime max, DateTime min)
            : this(max, min, false)
        { }

        /// <summary>
        /// max与min的相差天数应小于Int32.MaxValue
        /// </summary>
        /// <param name="max"></param>
        /// <param name="min"></param>
        public DateTimeRandomValue(DateTime max, DateTime min, bool isNull)
        {
            this.maxDate = max;
            TimeSpan span = max - min;
            spanDays = Convert.ToInt32(span.TotalDays);
            this.isNull = isNull;
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

            int day = randomer.Next(spanDays);
            if (randomer.Next(3) % 2 == 0)
            {
                if (WithQuotation)
                    return string.Format("{0:yyyy-MM-dd hh:mm:ss}", maxDate - new TimeSpan(day, 0, 0));
                else
                    return string.Format("'{0:yyyy-MM-dd hh:mm:ss}'", maxDate - new TimeSpan(day, 0, 0));
            }
            else
            {
                if (WithQuotation)
                    return string.Format("{0:yyyy-MM-dd hh:mm:ss}", maxDate - new TimeSpan(day, 0, 1));
                else
                    return string.Format("'{0:yyyy-MM-dd hh:mm:ss}'", maxDate - new TimeSpan(day, 0, 1));
            }
        }
    }
}
