using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class XmlPorts : IEnumerable<XmlPort>
    {
        private Dictionary<Int32,XmlPort> innerList = new Dictionary<Int32,XmlPort>();

        internal XmlPorts()
        {
        }

        public XmlPort Add(Int32 id, String name)
        {
            XmlPort item = new XmlPort(id, name);
            innerList.Add(id, item);
            return item;
        }

        public bool Remove(Int32 id)
        {
            return innerList.Remove(id);
        }

        public IEnumerator<XmlPort> GetEnumerator()
        {
            return innerList.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return innerList.Values.GetEnumerator();
        }
    }
}
