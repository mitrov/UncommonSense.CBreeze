using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class XmlPortFieldElementProperties : IEnumerable<Property>
    {
        private List<Property> innerList = new List<Property>();

        private NullableBooleanProperty autoCalcField = new NullableBooleanProperty("AutoCalcField");
        private TableFieldTypeProperty dataType = new TableFieldTypeProperty("DataType");
        private NullableBooleanProperty fieldValidate = new NullableBooleanProperty("FieldValidate");
        private MaxOccursProperty maxOccurs = new MaxOccursProperty("MaxOccurs");
        private MinOccursProperty minOccurs = new MinOccursProperty("MinOccurs");
        private ScopedTriggerProperty onAfterAssignField = new ScopedTriggerProperty("OnAfterAssignField");
        private ScopedTriggerProperty onBeforePassField = new ScopedTriggerProperty("OnBeforePassField");
        private SourceFieldProperty sourceField = new SourceFieldProperty("SourceField");
        private NullableIntegerProperty width = new NullableIntegerProperty("Width");

        internal XmlPortFieldElementProperties()
        {
            innerList.Add(dataType);
            innerList.Add(fieldValidate);
            innerList.Add(autoCalcField);
            innerList.Add(sourceField);
            innerList.Add(minOccurs);
            innerList.Add(maxOccurs);
            innerList.Add(onAfterAssignField);
            innerList.Add(onBeforePassField);
            innerList.Add(width);
        }

        public Property this[string name]
        {
            get
            {
                return innerList.FirstOrDefault(p => p.Name == name);
            }
        }

      public System.Boolean? AutoCalcField
        {
            get
            {
                return this.autoCalcField.Value;
            }
            set
            {
                this.autoCalcField.Value = value;
            }
        }

        public TableFieldType? DataType
        {
            get
            {
                return this.dataType.Value;
            }
            set
            {
                this.dataType.Value = value;
            }
        }

      public System.Boolean? FieldValidate
        {
            get
            {
                return this.fieldValidate.Value;
            }
            set
            {
                this.fieldValidate.Value = value;
            }
        }

        public MaxOccurs? MaxOccurs
        {
            get
            {
                return this.maxOccurs.Value;
            }
            set
            {
                this.maxOccurs.Value = value;
            }
        }

        public MinOccurs? MinOccurs
        {
            get
            {
                return this.minOccurs.Value;
            }
            set
            {
                this.minOccurs.Value = value;
            }
        }

        public Trigger OnAfterAssignField
        {
            get
            {
                return this.onAfterAssignField.Value;
            }
        }

        public Trigger OnBeforePassField
        {
            get
            {
                return this.onBeforePassField.Value;
            }
        }

        public SourceField SourceField
        {
            get
            {
                return this.sourceField.Value;
            }
        }

      public System.Int32? Width
        {
            get
            {
                return this.width.Value;
            }
            set
            {
                this.width.Value = value;
            }
        }

        public IEnumerator<Property> GetEnumerator()
        {
            return innerList.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return innerList.GetEnumerator();
        }

    }
}
