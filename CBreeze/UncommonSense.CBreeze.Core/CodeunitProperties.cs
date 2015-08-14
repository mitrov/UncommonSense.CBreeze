using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class CodeunitProperties : IEnumerable<Property>
    {
        private List<Property> innerList = new List<Property>();

        private NullableBooleanProperty cFRONTMayUsePermissions = new NullableBooleanProperty("CFRONTMayUsePermissions");
        private TriggerProperty onRun = new TriggerProperty("OnRun");
        private PermissionsProperty permissions = new PermissionsProperty("Permissions");
        private NullableBooleanProperty singleInstance = new NullableBooleanProperty("SingleInstance");
        private CodeunitSubTypeProperty subtype = new CodeunitSubTypeProperty("Subtype");
        private NullableIntegerProperty tableNo = new NullableIntegerProperty("TableNo");
        private TestIsolationProperty testIsolation = new TestIsolationProperty("TestIsolation");

        internal CodeunitProperties()
        {
            innerList.Add(tableNo);
            innerList.Add(permissions);
            innerList.Add(cFRONTMayUsePermissions);
            innerList.Add(singleInstance);
            innerList.Add(subtype);
            innerList.Add(testIsolation);
            innerList.Add(onRun);
        }

        public Property this[string name]
        {
            get
            {
                return innerList.FirstOrDefault(p => p.Name == name);
            }
        }

      public System.Boolean? CFRONTMayUsePermissions
        {
            get
            {
                return this.cFRONTMayUsePermissions.Value;
            }
            set
            {
                this.cFRONTMayUsePermissions.Value = value;
            }
        }

        public Trigger OnRun
        {
            get
            {
                return this.onRun.Value;
            }
        }

        public Permissions Permissions
        {
            get
            {
                return this.permissions.Value;
            }
        }

      public System.Boolean? SingleInstance
        {
            get
            {
                return this.singleInstance.Value;
            }
            set
            {
                this.singleInstance.Value = value;
            }
        }

        public CodeunitSubType? Subtype
        {
            get
            {
                return this.subtype.Value;
            }
            set
            {
                this.subtype.Value = value;
            }
        }

      public System.Int32? TableNo
        {
            get
            {
                return this.tableNo.Value;
            }
            set
            {
                this.tableNo.Value = value;
            }
        }

        public TestIsolation? TestIsolation
        {
            get
            {
                return this.testIsolation.Value;
            }
            set
            {
                this.testIsolation.Value = value;
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
