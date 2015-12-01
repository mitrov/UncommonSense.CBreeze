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
    public partial class CodeTableField : TableField
    {
        private CodeTableFieldProperties properties = new CodeTableFieldProperties();
        private int dataLength;

        public CodeTableField(int no, String name, int dataLength = 10) : base(no, name)
        {
            this.dataLength = dataLength;
        }

        public override TableFieldType Type
        {
            get
            {
                return TableFieldType.Code;
            }
        }

        public CodeTableFieldProperties Properties
        {
            get
            {
                return this.properties;
            }
        }

        public int DataLength
        {
            get
            {
                return this.dataLength;
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
