using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public partial class PageAction : PageActionBase
    {
        private PageActionProperties properties = new PageActionProperties();

        internal PageAction(Int32 id, Int32? indentationLevel) : base(id, indentationLevel)
        {
        }

        public override PageActionBaseType Type
        {
            get
            {
                return PageActionBaseType.PageAction;
            }
        }

        public PageActionProperties Properties
        {
            get
            {
                return this.properties;
            }
        }

    }
}
