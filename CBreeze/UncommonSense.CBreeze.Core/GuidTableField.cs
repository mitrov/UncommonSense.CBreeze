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
    public partial class GuidTableField : TableField
    {
        private GuidTableFieldProperties properties = new GuidTableFieldProperties();

        public GuidTableField(int no, String name) : base(no, name)
        {
        }

        public override TableFieldType Type
        {
            get
            {
                return TableFieldType.Guid;
            }
        }

        public GuidTableFieldProperties Properties
        {
            get
            {
                return this.properties;
            }
        }

        public override Properties AllProperties
        {
            get
            {
                return Properties;
            }
        }
    }
}
