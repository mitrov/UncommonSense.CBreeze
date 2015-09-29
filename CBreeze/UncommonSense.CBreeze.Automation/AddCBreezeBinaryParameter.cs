﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using UncommonSense.CBreeze.Core;

namespace UncommonSense.CBreeze.Automation
{
    [Cmdlet(VerbsCommon.Add, "CBreezeBinaryParameter")]
    public class AddCBreezeBinaryParameter : AddCBreezeParameter<BinaryParameter>
    {
        [Parameter()]
        [ValidateRange(1, int.MaxValue)]
        public int? DataLength
        {
            get;
            set;
        }

        protected override BinaryParameter CreateParameter()
        {
            return Parameters.Add(new BinaryParameter(Var, GetParameterID(), Name, DataLength.GetValueOrDefault(4)));
        }
    }
}
