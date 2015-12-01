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
    public partial class RecordVariable : Variable
    {
        private String dimensions;
        private RecordSecurityFiltering? securityFiltering;
        private int subType;
        private Boolean? temporary;

        public RecordVariable(int id, String name, int subType) : base(id, name)
        {
            this.subType = subType;
        }

        public override VariableType Type
        {
            get
            {
                return VariableType.Record;
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

        public int SubType
        {
            get
            {
                return this.subType;
            }
        }

        public Boolean? Temporary
        {
            get
            {
                return this.temporary;
            }
            set
            {
                this.temporary = value;
            }
        }

    }
}
