// --------------------------------------------------------------------------------
// <auto-generated>
//      This code was generated by a tool.
//
//      Changes to this file may cause incorrect behaviour and will be lost if
//      the code is regenerated.
// </auto-generated>
// --------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public partial class AutomationParameter : Parameter
    {
        private String subType;

        public AutomationParameter(Boolean var, Int32 id, String name, String subType) : base(var, id, name)
        {
            this.subType = subType;
        }

        public override ParameterType Type
        {
            get
            {
                return ParameterType.Automation;
            }
        }

        public String SubType
        {
            get
            {
                return this.subType;
            }
        }

    }
}
