using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class NullableDecimalProperty : Property
    {
        private System.Decimal? value = null;

        internal NullableDecimalProperty(string name) : base(name)
        {
        }

        public override bool HasValue
        {
            get
            {
                return Value.HasValue;
            }
        }

        public System.Decimal? Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }
    }

}
