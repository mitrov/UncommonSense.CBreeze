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
    public partial class XmlPortFieldAttribute : XmlPortNode
    {
        private XmlPortFieldAttributeProperties properties = new XmlPortFieldAttributeProperties();

        public XmlPortFieldAttribute(Guid id, String nodeName, int? indentationLevel) : base(id, nodeName, indentationLevel)
        {
        }

        public override XmlPortNodeType Type
        {
            get
            {
                return XmlPortNodeType.XmlPortFieldAttribute;
            }
        }

        public XmlPortFieldAttributeProperties Properties
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
