using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class MultiLanguageValue : IEnumerable<MultiLanguageEntry>
    {
        private Dictionary<String,MultiLanguageEntry> innerList = new Dictionary<String,MultiLanguageEntry>();

        internal MultiLanguageValue()
        {
        }

        public MultiLanguageEntry Add(String languageID, String value)
        {
            MultiLanguageEntry item = new MultiLanguageEntry(languageID, value);
            innerList.Add(languageID, item);
            return item;
        }

        public bool Remove(String languageID)
        {
            return innerList.Remove(languageID);
        }

        public IEnumerator<MultiLanguageEntry> GetEnumerator()
        {
            return innerList.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return innerList.Values.GetEnumerator();
        }
    }
}
