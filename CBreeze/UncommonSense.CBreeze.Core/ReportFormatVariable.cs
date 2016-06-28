﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UncommonSense.CBreeze.Common;

namespace UncommonSense.CBreeze.Core
{
#if NAV2016
        public class ReportFormatVariable : Variable
    {
        public ReportFormatVariable(int id, string name)
            : base(id, name)
        {
        }

        public override VariableType Type
        {
            get
            {
                return VariableType.ReportFormat;
            }
        }

        public string Dimensions
        {
            get;
            set;
        }
    }
#endif
}
