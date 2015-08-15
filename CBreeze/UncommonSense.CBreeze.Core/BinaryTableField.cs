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
    public partial class BinaryTableField : TableField
    {
        private Int32 dataLength;
        private BinaryTableFieldProperties properties = new BinaryTableFieldProperties();

        public BinaryTableField(Int32 no, String name, Int32 dataLength = 4) : base(no, name)
        {
            this.dataLength = dataLength;
        }

        public override TableFieldType Type
        {
            get
            {
                return TableFieldType.Binary;
            }
        }

        public Int32 DataLength
        {
            get
            {
                return this.dataLength;
            }
        }

        public BinaryTableFieldProperties Properties
        {
            get
            {
                return this.properties;
            }
        }

    }
}
