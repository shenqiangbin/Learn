using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlGenerator
{
    public enum IdentityRandomValueFormat
    {
        Numberic,
        String
    }
    public class IdentityRandomValue : RandomValues
    {
        private long seed;
        private int increment;
        private IdentityRandomValueFormat valueFormat;

        public IdentityRandomValue(long seed, int increment, IdentityRandomValueFormat valueFormat)
        {
            this.seed = seed;
            this.increment = increment;
            this.valueFormat = valueFormat;
        }
        public override object Generate()
        {
            long value = seed;
            seed = seed + increment;
            if (WithQuotation == true || valueFormat == IdentityRandomValueFormat.Numberic)
                return value;
            else if (valueFormat == IdentityRandomValueFormat.String)
                return string.Format("'{0}'", value);
            return value;
        }
    }
}
