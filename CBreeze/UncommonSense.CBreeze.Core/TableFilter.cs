using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class TableFilter : IEnumerable<TableFilterLine>
    {
        private List<TableFilterLine> innerList = new List<TableFilterLine>();

        internal TableFilter()
        {
        }

        public int FindIndex(Predicate<TableFilterLine> match)
        {
            return innerList.FindIndex(match);
        }

        public int FindIndex(int startIndex, Predicate<TableFilterLine> match)
        {
            return innerList.FindIndex(startIndex, match);
        }

        public int FindIndex(int startIndex, int count,Predicate<TableFilterLine> match)
        {
            return innerList.FindIndex(startIndex, count, match);
        }

        public int FindLastIndex(Predicate<TableFilterLine> match)
        {
            return innerList.FindLastIndex(match);
        }

        public int FindLastIndex(int startIndex, Predicate<TableFilterLine> match)
        {
            return innerList.FindLastIndex(startIndex, match);
        }

        public int FindLastIndex(int startIndex, int count, Predicate<TableFilterLine> match)
        {
            return innerList.FindLastIndex(startIndex, count, match);
        }

        public TableFilterLine Add(String fieldName, TableFilterType type, String value)
        {
            TableFilterLine item = new TableFilterLine(fieldName, type, value);
            innerList.Add(item);
            return item;
        }

        public TableFilterLine Insert(int index, String fieldName, TableFilterType type, String value)
        {
            TableFilterLine item = new TableFilterLine(fieldName, type, value);
            innerList.Insert(index, item);
            return item;
        }

        public void RemoveAt(int index)
        {
            innerList.RemoveAt(index);
        }

        public IEnumerator<TableFilterLine> GetEnumerator()
        {
            return innerList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return innerList.GetEnumerator();
        }
    }
}
