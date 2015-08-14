using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class MenuSuiteMenuNodeProperties : IEnumerable<Property>
    {
        private List<Property> innerList = new List<Property>();

        private MultiLanguageProperty captionML = new MultiLanguageProperty("CaptionML");
        private NullableBooleanProperty enabled = new NullableBooleanProperty("Enabled");
        private NullableGuidProperty firstChild = new NullableGuidProperty("FirstChild");
        private NullableIntegerProperty image = new NullableIntegerProperty("Image");
        private NullableBooleanProperty isShortcut = new NullableBooleanProperty("IsShortcut");
        private NullableGuidProperty memberOfMenu = new NullableGuidProperty("MemberOfMenu");
        private StringProperty name = new StringProperty("Name");
        private NullableGuidProperty nextNodeID = new NullableGuidProperty("NextNodeID");
        private NullableGuidProperty parentNodeID = new NullableGuidProperty("ParentNodeID");
        private NullableBooleanProperty visible = new NullableBooleanProperty("Visible");

        internal MenuSuiteMenuNodeProperties()
        {
            innerList.Add(name);
            innerList.Add(captionML);
            innerList.Add(memberOfMenu);
            innerList.Add(parentNodeID);
            innerList.Add(image);
            innerList.Add(isShortcut);
            innerList.Add(visible);
            innerList.Add(enabled);
            innerList.Add(nextNodeID);
            innerList.Add(firstChild);
        }

        public Property this[string name]
        {
            get
            {
                return innerList.FirstOrDefault(p => p.Name == name);
            }
        }

        public MultiLanguageValue CaptionML
        {
            get
            {
                return this.captionML.Value;
            }
        }

      public System.Boolean? Enabled
        {
            get
            {
                return this.enabled.Value;
            }
            set
            {
                this.enabled.Value = value;
            }
        }

      public System.Guid? FirstChild
        {
            get
            {
                return this.firstChild.Value;
            }
            set
            {
                this.firstChild.Value = value;
            }
        }

      public System.Int32? Image
        {
            get
            {
                return this.image.Value;
            }
            set
            {
                this.image.Value = value;
            }
        }

      public System.Boolean? IsShortcut
        {
            get
            {
                return this.isShortcut.Value;
            }
            set
            {
                this.isShortcut.Value = value;
            }
        }

      public System.Guid? MemberOfMenu
        {
            get
            {
                return this.memberOfMenu.Value;
            }
            set
            {
                this.memberOfMenu.Value = value;
            }
        }

      public System.String Name
        {
            get
            {
                return this.name.Value;
            }
            set
            {
                this.name.Value = value;
            }
        }

      public System.Guid? NextNodeID
        {
            get
            {
                return this.nextNodeID.Value;
            }
            set
            {
                this.nextNodeID.Value = value;
            }
        }

      public System.Guid? ParentNodeID
        {
            get
            {
                return this.parentNodeID.Value;
            }
            set
            {
                this.parentNodeID.Value = value;
            }
        }

      public System.Boolean? Visible
        {
            get
            {
                return this.visible.Value;
            }
            set
            {
                this.visible.Value = value;
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