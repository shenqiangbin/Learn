using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlGenerator
{
    public class GUIDRandomValue : RandomValues
    {
        private Random randomer = new Random();

        public GUIDRandomValue()
            : this(false)
        { }

        public GUIDRandomValue(bool isNull)
        {
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

            if (WithQuotation)
                return string.Format("{0}", Guid.NewGuid());
            else
                return string.Format("'{0}'", Guid.NewGuid());
        }
    }
}
