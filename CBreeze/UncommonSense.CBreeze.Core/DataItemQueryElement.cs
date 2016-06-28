using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UncommonSense.CBreeze.Common;

namespace UncommonSense.CBreeze.Core
{
        public class DataItemQueryElement : QueryElement
    {
        public DataItemQueryElement(int id, string name, int? indentationLevel)
            : base(id, name, indentationLevel)
        {
            Properties = new DataItemQueryElementProperties();
        }

        public override QueryElementType Type
        {
            get
            {
                return QueryElementType.DataItem;
            }
        }

        public DataItemQueryElementProperties Properties
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
