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
    public partial class IntegerTableField : TableField
    {
        public IntegerTableField(int no, string name)
            : base(no, name)
        {
            Properties = new IntegerTableFieldProperties();
        }

        public override TableFieldType Type
        {
            get
            {
                return TableFieldType.Integer;
            }
        }

        public IntegerTableFieldProperties Properties
        {
            get;
            protected set;
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
