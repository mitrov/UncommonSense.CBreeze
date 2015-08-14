using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class Queries : IEnumerable<Query>
    {
        private Dictionary<Int32,Query> innerList = new Dictionary<Int32,Query>();

        internal Queries()
        {
        }

        public Query Add(Int32 id, String name)
        {
            Query item = new Query(id, name);
            innerList.Add(id, item);
            return item;
        }

        public bool Remove(Int32 id)
        {
            return innerList.Remove(id);
        }

        public IEnumerator<Query> GetEnumerator()
        {
            return innerList.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return innerList.Values.GetEnumerator();
        }
    }
}