﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using UncommonSense.CBreeze.Core;

namespace UncommonSense.CBreeze.Automation
{
    [Cmdlet(VerbsCommon.New, "CBreezeReportLabel")]
    [OutputType(typeof(ReportLabel))]
    [Alias("ReportLabel")]
    public class NewCBreezeReportLabel : NewItemWithIDAndNameCmdlet<ReportLabel, int, Report>
    {
        protected override void AddItemToInputObject(ReportLabel item, Report inputObject)
        {
            inputObject.Labels.Add(item);
        }

        protected override IEnumerable<ReportLabel> CreateItems()
        {
            var reportLabel = new ReportLabel(ID, Name);
            reportLabel.Properties.CaptionML.Set("ENU", Caption);
            reportLabel.Properties.Description = Description;
            yield return reportLabel;
        }

        [Parameter()]
        public string Caption
        {
            get;
            set;
        }

        [Parameter()]
        public string Description
        {
            get;
            set;
        }
    }
}