using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class Codeunits : IEnumerable<Codeunit>
    {
        private Dictionary<Int32,Codeunit> innerList = new Dictionary<Int32,Codeunit>();

        internal Codeunits()
        {
        }

        public Codeunit Add(Int32 id, String name)
        {
            Codeunit item = new Codeunit(id, name);
            innerList.Add(id, item);
            return item;
        }

        public bool Remove(Int32 id)
        {
            return innerList.Remove(id);
        }

        public IEnumerator<Codeunit> GetEnumerator()
        {
            return innerList.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return innerList.Values.GetEnumerator();
        }
    }
}
