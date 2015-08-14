using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class ImportanceProperty : Property
    {
        private Importance? value = null;

        internal ImportanceProperty(string name) : base(name)
        {
        }

        public override bool HasValue
        {
            get
            {
                return Value.HasValue;
            }
        }

        public Importance? Value
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
