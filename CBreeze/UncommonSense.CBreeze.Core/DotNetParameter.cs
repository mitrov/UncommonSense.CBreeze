using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public partial class DotNetParameter : Parameter
    {
        private String dimensions;
        private Boolean? runOnClient;
        private String subType;
        private Boolean? suppressDispose;

        internal DotNetParameter(Boolean var, Int32 id, String name, String subType) : base(var, id, name)
        {
            this.subType = subType;
        }

        public override ParameterType Type
        {
            get
            {
                return ParameterType.DotNet;
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

        public Boolean? RunOnClient
        {
            get
            {
                return this.runOnClient;
            }
            set
            {
                this.runOnClient = value;
            }
        }

        public String SubType
        {
            get
            {
                return this.subType;
            }
        }

        public Boolean? SuppressDispose
        {
            get
            {
                return this.suppressDispose;
            }
            set
            {
                this.suppressDispose = value;
            }
        }

    }
}
