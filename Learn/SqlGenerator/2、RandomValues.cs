using System;
using System.Collections.Generic;
using System.Text;

namespace SqlGenerator
{
    public abstract class RandomValues
    {
        protected bool isNull;
        private bool withQuotation = true;

        /// <summary>
        /// 输出是否带有双引号
        /// </summary>
        public bool WithQuotation
        {
            get { return withQuotation; }
            set { withQuotation = value; }
        }

        public abstract object Generate();
    }
}
