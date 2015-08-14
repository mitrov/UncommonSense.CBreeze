using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class FieldList : IEnumerable<FieldReference>
    {
        private List<FieldReference> innerList = new List<FieldReference>();

        internal FieldList()
        {
        }

        public int FindIndex(Predicate<FieldReference> match)
        {
            return innerList.FindIndex(match);
        }

        public int FindIndex(int startIndex, Predicate<FieldReference> match)
        {
            return innerList.FindIndex(startIndex, match);
        }

        public int FindIndex(int startIndex, int count,Predicate<FieldReference> match)
        {
            return innerList.FindIndex(startIndex, count, match);
        }

        public int FindLastIndex(Predicate<FieldReference> match)
        {
            return innerList.FindLastIndex(match);
        }

        public int FindLastIndex(int startIndex, Predicate<FieldReference> match)
        {
            return innerList.FindLastIndex(startIndex, match);
        }

        public int FindLastIndex(int startIndex, int count, Predicate<FieldReference> match)
        {
            return innerList.FindLastIndex(startIndex, count, match);
        }

        public FieldReference Add(String fieldName)
        {
            FieldReference item = new FieldReference(fieldName);
            innerList.Add(item);
            return item;
        }

        public void AddRange(params String[] fieldNames)
        {
            foreach(var item in fieldNames)
            {
               innerList.Add(new FieldReference(item));
             }
        }

        public FieldReference Insert(int index, String fieldName)
        {
            FieldReference item = new FieldReference(fieldName);
            innerList.Insert(index, item);
            return item;
        }

        public void RemoveAt(int index)
        {
            innerList.RemoveAt(index);
        }

        public IEnumerator<FieldReference> GetEnumerator()
        {
            return innerList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return innerList.GetEnumerator();
        }
    }
}