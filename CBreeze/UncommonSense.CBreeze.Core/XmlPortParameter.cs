using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public partial class XmlPortParameter : Parameter
    {
        private String dimensions;
        private Int32 subType;

        internal XmlPortParameter(Boolean var, Int32 id, String name, Int32 subType) : base(var, id, name)
        {
            this.subType = subType;
        }

        public override ParameterType Type
        {
            get
            {
                return ParameterType.XmlPort;
            }
        }

        public String Dimensions
        {
            get
            {
                return this.dimensions;
            }
            set
            {
                this.dimensions = value;
            }
        }

        public Int32 SubType
        {
            get
            {
                return this.subType;
            }
        }

    }
}