using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public partial class RecordRefVariable : Variable
    {
        private String dimensions;
        private RecordSecurityFiltering? securityFiltering;

        internal RecordRefVariable(Int32 id, String name) : base(id, name)
        {
        }

        public override VariableType Type
        {
            get
            {
                return VariableType.RecordRef;
            }
        }

        public String Dimensions
        {
            get
            {
                return this.dimensions;
            }
            set
            {
                this.dimensions = value;
            }
        }

        public RecordSecurityFiltering? SecurityFiltering
        {
            get
            {
                return this.securityFiltering;
            }
            set
            {
                this.securityFiltering = value;
            }
        }

    }
}
