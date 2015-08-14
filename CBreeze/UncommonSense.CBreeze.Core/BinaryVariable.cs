using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public partial class BinaryVariable : Variable
    {
        private Int32 dataLength;
        private String dimensions;

        internal BinaryVariable(Int32 id, String name, Int32 dataLength = 100) : base(id, name)
        {
            this.dataLength = dataLength;
        }

        public override VariableType Type
        {
            get
            {
                return VariableType.Binary;
            }
        }

        public Int32 DataLength
        {
            get
            {
                return this.dataLength;
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

    }
}
