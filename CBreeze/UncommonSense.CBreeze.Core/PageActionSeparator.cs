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
    public partial class PageActionSeparator : PageActionBase
    {
        public PageActionSeparator(int id, int? indentationLevel)
            : base(id, indentationLevel)
        {
            Properties = new PageActionSeparatorProperties();
        }

        public override PageActionBaseType Type
        {
            get
            {
                return PageActionBaseType.Separator;
            }
        }

        public PageActionSeparatorProperties Properties
        {
            get;
            protected set;
        }

        public override string GetName()
        {
            return null;
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
