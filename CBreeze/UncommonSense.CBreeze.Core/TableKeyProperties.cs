using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class TableKeyProperties : IEnumerable<Property>
    {
        private List<Property> innerList = new List<Property>();

        private NullableBooleanProperty clustered = new NullableBooleanProperty("Clustered");
        private StringProperty keyGroups = new StringProperty("KeyGroups");
        private NullableBooleanProperty maintainSIFTIndex = new NullableBooleanProperty("MaintainSIFTIndex");
        private NullableBooleanProperty maintainSQLIndex = new NullableBooleanProperty("MaintainSQLIndex");
        private SIFTLevelsProperty siftLevelsToMaintain = new SIFTLevelsProperty("SIFTLevelsToMaintain");
        private FieldListProperty sqlIndex = new FieldListProperty("SQLIndex");
        private FieldListProperty sumIndexFields = new FieldListProperty("SumIndexFields");

        internal TableKeyProperties()
        {
            innerList.Add(sumIndexFields);
            innerList.Add(keyGroups);
            innerList.Add(maintainSQLIndex);
            innerList.Add(maintainSIFTIndex);
            innerList.Add(sqlIndex);
            innerList.Add(siftLevelsToMaintain);
            innerList.Add(clustered);
        }

        public Property this[string name]
        {
            get
            {
                return innerList.FirstOrDefault(p => p.Name == name);
            }
        }

      public System.Boolean? Clustered
        {
            get
            {
                return this.clustered.Value;
            }
            set
            {
                this.clustered.Value = value;
            }
        }

      public System.String KeyGroups
        {
            get
            {
                return this.keyGroups.Value;
            }
            set
            {
                this.keyGroups.Value = value;
            }
        }

      public System.Boolean? MaintainSIFTIndex
        {
            get
            {
                return this.maintainSIFTIndex.Value;
            }
            set
            {
                this.maintainSIFTIndex.Value = value;
            }
        }

      public System.Boolean? MaintainSQLIndex
        {
            get
            {
                return this.maintainSQLIndex.Value;
            }
            set
            {
                this.maintainSQLIndex.Value = value;
            }
        }

        public SIFTLevels SIFTLevelsToMaintain
        {
            get
            {
                return this.siftLevelsToMaintain.Value;
            }
        }

        public FieldList SQLIndex
        {
            get
            {
                return this.sqlIndex.Value;
            }
        }

        public FieldList SumIndexFields
        {
            get
            {
                return this.sumIndexFields.Value;
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
