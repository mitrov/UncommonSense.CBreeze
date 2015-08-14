using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class RunObjectLinkProperty : Property
    {
        private RunObjectLink value = new RunObjectLink();

        internal RunObjectLinkProperty(string name) : base(name)
        {
        }

        public override bool HasValue
        {
            get
            {
                return Value.Any();
            }
        }

        public RunObjectLink Value
        {
            get
            {
                return this.value;
            }
        }
    }

}