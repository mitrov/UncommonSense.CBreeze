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
    public partial class PageAction : PageActionBase
    {
        public PageAction(int id, int? indentationLevel)
            : base(id, indentationLevel)
        {
            Properties = new PageActionProperties();
        }

        public override PageActionBaseType Type
        {
            get
            {
                return PageActionBaseType.Action;
            }
        }

        public PageActionProperties Properties
        {
            get;
            protected set;
        }

        public override string GetName()
        {
            return Properties.Name;
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
