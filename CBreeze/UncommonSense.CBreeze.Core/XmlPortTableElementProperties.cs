// --------------------------------------------------------------------------------
// <auto-generated>
//      This code was generated by a tool.
//
//      Changes to this file may cause incorrect behaviour and will be lost if
//      the code is regenerated.
// </auto-generated>
// --------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class XmlPortTableElementProperties : Properties
    {
        private NullableBooleanProperty autoReplace = new NullableBooleanProperty("AutoReplace");
        private NullableBooleanProperty autoSave = new NullableBooleanProperty("AutoSave");
        private NullableBooleanProperty autoUpdate = new NullableBooleanProperty("AutoUpdate");
        private FieldListProperty calcFields = new FieldListProperty("CalcFields");
        private LinkFieldsProperty linkFields = new LinkFieldsProperty("LinkFields");
        private StringProperty linkTable = new StringProperty("LinkTable");
        private NullableBooleanProperty linkTableForceInsert = new NullableBooleanProperty("LinkTableForceInsert");
        private MaxOccursProperty maxOccurs = new MaxOccursProperty("MaxOccurs");
        private MinOccursProperty minOccurs = new MinOccursProperty("MinOccurs");
        private ScopedTriggerProperty onAfterGetRecord = new ScopedTriggerProperty("OnAfterGetRecord");
        private ScopedTriggerProperty onAfterInitRecord = new ScopedTriggerProperty("OnAfterInitRecord");
        private ScopedTriggerProperty onAfterInsertRecord = new ScopedTriggerProperty("OnAfterInsertRecord");
        private ScopedTriggerProperty onAfterModifyRecord = new ScopedTriggerProperty("OnAfterModifyRecord");
        private ScopedTriggerProperty onBeforeInsertRecord = new ScopedTriggerProperty("OnBeforeInsertRecord");
        private ScopedTriggerProperty onBeforeModifyRecord = new ScopedTriggerProperty("OnBeforeModifyRecord");
        private ScopedTriggerProperty onPreXMLItem = new ScopedTriggerProperty("OnPreXMLItem");
        private FieldListProperty reqFilterFields = new FieldListProperty("ReqFilterFields");
        private MultiLanguageProperty reqFilterHeadingML = new MultiLanguageProperty("ReqFilterHeadingML");
        private TableReferenceProperty sourceTable = new TableReferenceProperty("SourceTable");
        private TableViewProperty sourceTableView = new TableViewProperty("SourceTableView");
        private NullableBooleanProperty temporary = new NullableBooleanProperty("Temporary");
        private StringProperty variableName = new StringProperty("VariableName");
        private NullableIntegerProperty width = new NullableIntegerProperty("Width");

        internal XmlPortTableElementProperties()
        {
            innerList.Add(reqFilterFields);
            innerList.Add(reqFilterHeadingML);
            innerList.Add(variableName);
            innerList.Add(sourceTable);
            innerList.Add(sourceTableView);
            innerList.Add(calcFields);
            innerList.Add(linkFields);
            innerList.Add(linkTable);
            innerList.Add(temporary);
            innerList.Add(linkTableForceInsert);
            innerList.Add(autoSave);
            innerList.Add(autoUpdate);
            innerList.Add(autoReplace);
            innerList.Add(minOccurs);
            innerList.Add(maxOccurs);
            innerList.Add(onAfterInitRecord);
            innerList.Add(onBeforeInsertRecord);
            innerList.Add(onPreXMLItem);
            innerList.Add(onAfterGetRecord);
            innerList.Add(onAfterInsertRecord);
            innerList.Add(onBeforeModifyRecord);
            innerList.Add(onAfterModifyRecord);
            innerList.Add(width);
        }

      public System.Boolean? AutoReplace
        {
            get
            {
                return this.autoReplace.Value;
            }
            set
            {
                this.autoReplace.Value = value;
            }
        }

      public System.Boolean? AutoSave
        {
            get
            {
                return this.autoSave.Value;
            }
            set
            {
                this.autoSave.Value = value;
            }
        }

      public System.Boolean? AutoUpdate
        {
            get
            {
                return this.autoUpdate.Value;
            }
            set
            {
                this.autoUpdate.Value = value;
            }
        }

        public FieldList CalcFields
        {
            get
            {
                return this.calcFields.Value;
            }
        }

        public LinkFields LinkFields
        {
            get
            {
                return this.linkFields.Value;
            }
        }

      public System.String LinkTable
        {
            get
            {
                return this.linkTable.Value;
            }
            set
            {
                this.linkTable.Value = value;
            }
        }

      public System.Boolean? LinkTableForceInsert
        {
            get
            {
                return this.linkTableForceInsert.Value;
            }
            set
            {
                this.linkTableForceInsert.Value = value;
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

        public Trigger OnAfterGetRecord
        {
            get
            {
                return this.onAfterGetRecord.Value;
            }
        }

        public Trigger OnAfterInitRecord
        {
            get
            {
                return this.onAfterInitRecord.Value;
            }
        }

        public Trigger OnAfterInsertRecord
        {
            get
            {
                return this.onAfterInsertRecord.Value;
            }
        }

        public Trigger OnAfterModifyRecord
        {
            get
            {
                return this.onAfterModifyRecord.Value;
            }
        }

        public Trigger OnBeforeInsertRecord
        {
            get
            {
                return this.onBeforeInsertRecord.Value;
            }
        }

        public Trigger OnBeforeModifyRecord
        {
            get
            {
                return this.onBeforeModifyRecord.Value;
            }
        }

        public Trigger OnPreXMLItem
        {
            get
            {
                return this.onPreXMLItem.Value;
            }
        }

        public FieldList ReqFilterFields
        {
            get
            {
                return this.reqFilterFields.Value;
            }
        }

        public MultiLanguageValue ReqFilterHeadingML
        {
            get
            {
                return this.reqFilterHeadingML.Value;
            }
        }

      public System.int? SourceTable
        {
            get
            {
                return this.sourceTable.Value;
            }
            set
            {
                this.sourceTable.Value = value;
            }
        }

        public TableView SourceTableView
        {
            get
            {
                return this.sourceTableView.Value;
            }
        }

      public System.Boolean? Temporary
        {
            get
            {
                return this.temporary.Value;
            }
            set
            {
                this.temporary.Value = value;
            }
        }

      public System.String VariableName
        {
            get
            {
                return this.variableName.Value;
            }
            set
            {
                this.variableName.Value = value;
            }
        }

      public System.int? Width
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
    }
}
