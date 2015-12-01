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
    public partial class TextTableField : TableField
    {
        private int dataLength;
        private TextTableFieldProperties properties = new TextTableFieldProperties();

        public TextTableField(int no, String name, int dataLength = 30) : base(no, name)
        {
            this.dataLength = dataLength;
        }

        public override TableFieldType Type
        {
            get
            {
                return TableFieldType.Text;
            }
        }

        public int DataLength
        {
            get
            {
                return this.dataLength;
            }
        }

        public TextTableFieldProperties Properties
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
