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

        internal GuidTableField(Int32 no, String name) : base(no, name)
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

    }
}
