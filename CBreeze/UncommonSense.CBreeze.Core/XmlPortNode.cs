using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public abstract partial class XmlPortNode
    {
        private Guid id;
        private String nodeName;
        private Int32? indentationLevel;

        internal XmlPortNode(Guid id, String nodeName, Int32? indentationLevel)
        {
            this.id = id;
            this.indentationLevel = indentationLevel;
            this.nodeName = nodeName;
        }

        public abstract XmlPortNodeType Type
        {
            get;
        }

        public Guid ID
        {
            get
            {
                return this.id;
            }
        }

        public String NodeName
        {
            get
            {
                return this.nodeName;
            }
        }

        public Int32? IndentationLevel
        {
            get
            {
                return this.indentationLevel;
            }
        }

    }
}
