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
    public partial class DataItemReportElement : ReportElement
    {
        private DataItemReportElementProperties properties = new DataItemReportElementProperties();

        public DataItemReportElement(int id, int? indentationLevel) : base(id, indentationLevel)
        {
        }

        public override ReportElementType Type
        {
            get
            {
                return ReportElementType.DataItem;
            }
        }

        public DataItemReportElementProperties Properties
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
