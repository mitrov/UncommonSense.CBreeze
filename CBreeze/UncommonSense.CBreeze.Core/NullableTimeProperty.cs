using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class NullableTimeProperty : Property
    {
        private System.TimeSpan? value = null;

        internal NullableTimeProperty(string name) : base(name)
        {
        }

        public override bool HasValue
        {
            get
            {
                return Value.HasValue;
            }
        }

        public System.TimeSpan? Value
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
