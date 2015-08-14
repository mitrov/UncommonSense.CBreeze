using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class PartPageControlProperties : IEnumerable<Property>
    {
        private List<Property> innerList = new List<Property>();

        private MultiLanguageProperty captionML = new MultiLanguageProperty("CaptionML");
        private StringProperty chartPartID = new StringProperty("ChartPartID");
        private StringProperty description = new StringProperty("Description");
        private StringProperty editable = new StringProperty("Editable");
        private StringProperty enabled = new StringProperty("Enabled");
        private StringProperty name = new StringProperty("Name");
        private PageReferenceProperty pagePartID = new PageReferenceProperty("PagePartID");
        private PartTypeProperty partType = new PartTypeProperty("PartType");
        private NullableIntegerProperty providerID = new NullableIntegerProperty("ProviderID");
        private NullableBooleanProperty showFilter = new NullableBooleanProperty("ShowFilter");
        private RunObjectLinkProperty subPageLink = new RunObjectLinkProperty("SubPageLink");
        private TableViewProperty subPageView = new TableViewProperty("SubPageView");
        private SystemPartIDProperty systemPartID = new SystemPartIDProperty("SystemPartID");
        private MultiLanguageProperty toolTipML = new MultiLanguageProperty("ToolTipML");
        private StringProperty visible = new StringProperty("Visible");

        internal PartPageControlProperties()
        {
            innerList.Add(name);
            innerList.Add(captionML);
            innerList.Add(toolTipML);
            innerList.Add(description);
            innerList.Add(subPageView);
            innerList.Add(subPageLink);
            innerList.Add(pagePartID);
            innerList.Add(providerID);
            innerList.Add(visible);
            innerList.Add(enabled);
            innerList.Add(editable);
            innerList.Add(partType);
            innerList.Add(systemPartID);
            innerList.Add(chartPartID);
            innerList.Add(showFilter);
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

      public System.String ChartPartID
        {
            get
            {
                return this.chartPartID.Value;
            }
            set
            {
                this.chartPartID.Value = value;
            }
        }

      public System.String Description
        {
            get
            {
                return this.description.Value;
            }
            set
            {
                this.description.Value = value;
            }
        }

      public System.String Editable
        {
            get
            {
                return this.editable.Value;
            }
            set
            {
                this.editable.Value = value;
            }
        }

      public System.String Enabled
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

      public System.Int32? PagePartID
        {
            get
            {
                return this.pagePartID.Value;
            }
            set
            {
                this.pagePartID.Value = value;
            }
        }

        public PartType? PartType
        {
            get
            {
                return this.partType.Value;
            }
            set
            {
                this.partType.Value = value;
            }
        }

      public System.Int32? ProviderID
        {
            get
            {
                return this.providerID.Value;
            }
            set
            {
                this.providerID.Value = value;
            }
        }

      public System.Boolean? ShowFilter
        {
            get
            {
                return this.showFilter.Value;
            }
            set
            {
                this.showFilter.Value = value;
            }
        }

        public RunObjectLink SubPageLink
        {
            get
            {
                return this.subPageLink.Value;
            }
        }

        public TableView SubPageView
        {
            get
            {
                return this.subPageView.Value;
            }
        }

        public SystemPartID? SystemPartID
        {
            get
            {
                return this.systemPartID.Value;
            }
            set
            {
                this.systemPartID.Value = value;
            }
        }

        public MultiLanguageValue ToolTipML
        {
            get
            {
                return this.toolTipML.Value;
            }
        }

      public System.String Visible
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