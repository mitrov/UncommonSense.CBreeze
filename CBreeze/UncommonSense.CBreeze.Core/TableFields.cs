using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class TableFields : IEnumerable<TableField>
    {
        private Dictionary<Int32,TableField> innerList = new Dictionary<Int32,TableField>();

        internal TableFields()
        {
        }

        public BigIntegerTableField AddBigIntegerTableField(Int32 no, String name)
        {
            BigIntegerTableField item = new BigIntegerTableField(no, name);
            innerList.Add(no, item);
            return item;
        }

        public BinaryTableField AddBinaryTableField(Int32 no, String name, Int32 dataLength = 4)
        {
            BinaryTableField item = new BinaryTableField(no, name, dataLength);
            innerList.Add(no, item);
            return item;
        }

        public BlobTableField AddBlobTableField(Int32 no, String name)
        {
            BlobTableField item = new BlobTableField(no, name);
            innerList.Add(no, item);
            return item;
        }

        public BooleanTableField AddBooleanTableField(Int32 no, String name)
        {
            BooleanTableField item = new BooleanTableField(no, name);
            innerList.Add(no, item);
            return item;
        }

        public CodeTableField AddCodeTableField(Int32 no, String name, Int32 dataLength = 10)
        {
            CodeTableField item = new CodeTableField(no, name, dataLength);
            innerList.Add(no, item);
            return item;
        }

        public DateFormulaTableField AddDateFormulaTableField(Int32 no, String name)
        {
            DateFormulaTableField item = new DateFormulaTableField(no, name);
            innerList.Add(no, item);
            return item;
        }

        public DateTableField AddDateTableField(Int32 no, String name)
        {
            DateTableField item = new DateTableField(no, name);
            innerList.Add(no, item);
            return item;
        }

        public DateTimeTableField AddDateTimeTableField(Int32 no, String name)
        {
            DateTimeTableField item = new DateTimeTableField(no, name);
            innerList.Add(no, item);
            return item;
        }

        public DecimalTableField AddDecimalTableField(Int32 no, String name)
        {
            DecimalTableField item = new DecimalTableField(no, name);
            innerList.Add(no, item);
            return item;
        }

        public DurationTableField AddDurationTableField(Int32 no, String name)
        {
            DurationTableField item = new DurationTableField(no, name);
            innerList.Add(no, item);
            return item;
        }

        public GuidTableField AddGuidTableField(Int32 no, String name)
        {
            GuidTableField item = new GuidTableField(no, name);
            innerList.Add(no, item);
            return item;
        }

        public IntegerTableField AddIntegerTableField(Int32 no, String name)
        {
            IntegerTableField item = new IntegerTableField(no, name);
            innerList.Add(no, item);
            return item;
        }

        public OptionTableField AddOptionTableField(Int32 no, String name)
        {
            OptionTableField item = new OptionTableField(no, name);
            innerList.Add(no, item);
            return item;
        }

        public RecordIDTableField AddRecordIDTableField(Int32 no, String name)
        {
            RecordIDTableField item = new RecordIDTableField(no, name);
            innerList.Add(no, item);
            return item;
        }

        public TableFilterTableField AddTableFilterTableField(Int32 no, String name)
        {
            TableFilterTableField item = new TableFilterTableField(no, name);
            innerList.Add(no, item);
            return item;
        }

        public TextTableField AddTextTableField(Int32 no, String name, Int32 dataLength = 30)
        {
            TextTableField item = new TextTableField(no, name, dataLength);
            innerList.Add(no, item);
            return item;
        }

        public TimeTableField AddTimeTableField(Int32 no, String name)
        {
            TimeTableField item = new TimeTableField(no, name);
            innerList.Add(no, item);
            return item;
        }

        public bool Remove(Int32 no)
        {
            return innerList.Remove(no);
        }

        public IEnumerator<TableField> GetEnumerator()
        {
            return innerList.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return innerList.Values.GetEnumerator();
        }
    }
}