using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UncommonSense.CBreeze.Common;

namespace UncommonSense.CBreeze.Core
{
        public class InStreamParameter : Parameter
    {
        public InStreamParameter(bool var, int id, string name) : base(var, id, name)
        {
        }

        public override ParameterType Type
        {
            get
            {
                return ParameterType.InStream;
            }
        }

    }
}
