using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlGenerator
{
    public class BoolRandomValue : RandomValues
    {
        private Random randomer = new Random();

        public BoolRandomValue()
            : this(false)
        { }

        public BoolRandomValue(bool isNull)
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

            if (randomer.Next(1) == 0)
            {
                if (WithQuotation)
                    return "true";
                else
                    return string.Format("'{0}'", "true");
            }
            else
            {
                if (WithQuotation)
                    return "false";
                else
                    return string.Format("'{0}'", "false");
            }
        }
    }
}
