using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    public class PageProperties : Properties
    {
        private ActionListProperty actionList = new ActionListProperty("ActionList");
#if NAV2018
        private StringProperty apiVersion = new StringProperty("APIVersion");
#endif
        private NullableBooleanProperty autoSplitKey = new NullableBooleanProperty("AutoSplitKey");
        private MultiLanguageProperty captionML = new MultiLanguageProperty("CaptionML");
        private StringProperty cardPageID = new StringProperty("CardPageID");
        private StringProperty dataCaptionExpr = new StringProperty("DataCaptionExpr");
        private FieldListProperty dataCaptionFields = new FieldListProperty("DataCaptionFields");
        private NullableBooleanProperty delayedInsert = new NullableBooleanProperty("DelayedInsert");
        private NullableBooleanProperty deleteAllowed = new NullableBooleanProperty("DeleteAllowed");
        private StringProperty description = new StringProperty("Description");
#if NAV2018
        private StringProperty entityName = new StringProperty("EntityName");
        private StringProperty entitySetName = new StringProperty("EntitySetName");
#endif
        private NullableBooleanProperty editable = new NullableBooleanProperty("Editable");
        private NullableBooleanProperty insertAllowed = new NullableBooleanProperty("InsertAllowed");
        private MultiLanguageProperty instructionalTextML = new MultiLanguageProperty("InstructionalTextML");
        private NullableBooleanProperty linksAllowed = new NullableBooleanProperty("LinksAllowed");
        private NullableBooleanProperty modifyAllowed = new NullableBooleanProperty("ModifyAllowed");
        private NullableBooleanProperty multipleNewLines = new NullableBooleanProperty("MultipleNewLines");
#if NAV2018
        private FieldListProperty odataKeyFields = new FieldListProperty("ODataKeyFields");
#endif
        private TriggerProperty onAfterGetCurrRecord = new TriggerProperty("OnAfterGetCurrRecord");
        private TriggerProperty onAfterGetRecord = new TriggerProperty("OnAfterGetRecord");
        private TriggerProperty onClosePage = new TriggerProperty("OnClosePage");
        private TriggerProperty onDeleteRecord = new TriggerProperty("OnDeleteRecord");
        private TriggerProperty onFindRecord = new TriggerProperty("OnFindRecord");
        private TriggerProperty onInit = new TriggerProperty("OnInit");
        private TriggerProperty onInsertRecord = new TriggerProperty("OnInsertRecord");
        private TriggerProperty onModifyRecord = new TriggerProperty("OnModifyRecord");
        private TriggerProperty onNewRecord = new TriggerProperty("OnNewRecord");
        private TriggerProperty onNextRecord = new TriggerProperty("OnNextRecord");
        private TriggerProperty onOpenPage = new TriggerProperty("OnOpenPage");
        private TriggerProperty onQueryClosePage = new TriggerProperty("OnQueryClosePage");
        private PageTypeProperty pageType = new PageTypeProperty("PageType");
        private PermissionsProperty permissions = new PermissionsProperty("Permissions");
        private NullableBooleanProperty populateAllFields = new NullableBooleanProperty("PopulateAllFields");
        private MultiLanguageProperty promotedActionCategoriesML = new MultiLanguageProperty("PromotedActionCategoriesML");
        private NullableBooleanProperty refreshOnActivate = new NullableBooleanProperty("RefreshOnActivate");
        private NullableBooleanProperty saveValues = new NullableBooleanProperty("SaveValues");
        private NullableBooleanProperty showFilter = new NullableBooleanProperty("ShowFilter");
        private TableReferenceProperty sourceTable = new TableReferenceProperty("SourceTable");
        private NullableBooleanProperty sourceTableTemporary = new NullableBooleanProperty("SourceTableTemporary");
        private TableViewProperty sourceTableView = new TableViewProperty("SourceTableView");

        internal PageProperties(Page page)
        {
            Page = page;

            innerList.Add(permissions);
            innerList.Add(editable);
            innerList.Add(captionML);
            innerList.Add(description);
            innerList.Add(saveValues);
            innerList.Add(multipleNewLines);
            innerList.Add(insertAllowed);
            innerList.Add(deleteAllowed);
            innerList.Add(modifyAllowed);
            innerList.Add(linksAllowed);
            innerList.Add(sourceTable);
            innerList.Add(dataCaptionExpr);
            innerList.Add(delayedInsert);
            innerList.Add(populateAllFields);
            innerList.Add(sourceTableView);
            innerList.Add(dataCaptionFields);
            innerList.Add(pageType);
            innerList.Add(sourceTableTemporary);
#if NAV2018
            innerList.Add(entitySetName);
            innerList.Add(entityName);
#endif
            innerList.Add(cardPageID);
            innerList.Add(instructionalTextML);
            innerList.Add(autoSplitKey);
            innerList.Add(refreshOnActivate);
            innerList.Add(promotedActionCategoriesML);
            innerList.Add(showFilter);
            innerList.Add(onInit);
            innerList.Add(onOpenPage);
            innerList.Add(onClosePage);
            innerList.Add(onFindRecord);
            innerList.Add(onNextRecord);
            innerList.Add(onAfterGetRecord);
            innerList.Add(onNewRecord);
            innerList.Add(onInsertRecord);
            innerList.Add(onModifyRecord);
            innerList.Add(onDeleteRecord);
            innerList.Add(onQueryClosePage);
            innerList.Add(onAfterGetCurrRecord);
#if NAV2018
            innerList.Add(odataKeyFields);
            innerList.Add(apiVersion);
#endif
            innerList.Add(actionList);
        }

        public Page Page { get; protected set; }

        public override INode ParentNode => Page;

        public ActionList ActionList
        {
            get
            {
                return this.actionList.Value;
            }
        }

#if NAV2018

        public string APIVersion
        {
            get => apiVersion.Value;
            set => apiVersion.Value = value;
        }

#endif

        public bool? AutoSplitKey
        {
            get
            {
                return this.autoSplitKey.Value;
            }
            set
            {
                this.autoSplitKey.Value = value;
            }
        }

        public MultiLanguageValue CaptionML
        {
            get
            {
                return this.captionML.Value;
            }
        }

        public string CardPageID
        {
            get
            {
                return this.cardPageID.Value;
            }
            set
            {
                this.cardPageID.Value = value;
            }
        }

        public string DataCaptionExpr
        {
            get
            {
                return this.dataCaptionExpr.Value;
            }
            set
            {
                this.dataCaptionExpr.Value = value;
            }
        }

        public FieldList DataCaptionFields
        {
            get
            {
                return this.dataCaptionFields.Value;
            }
        }

        public bool? DelayedInsert
        {
            get
            {
                return this.delayedInsert.Value;
            }
            set
            {
                this.delayedInsert.Value = value;
            }
        }

        public bool? DeleteAllowed
        {
            get
            {
                return this.deleteAllowed.Value;
            }
            set
            {
                this.deleteAllowed.Value = value;
            }
        }

        public string Description
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

        public bool? Editable
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

#if NAV2018

        public string EntityName
        {
            get => entityName.Value;
            set => entityName.Value = value;
        }

        public string EntitySetName
        {
            get => entitySetName.Value;
            set => entitySetName.Value = value;
        }

#endif

        public bool? InsertAllowed
        {
            get
            {
                return this.insertAllowed.Value;
            }
            set
            {
                this.insertAllowed.Value = value;
            }
        }

        public MultiLanguageValue InstructionalTextML
        {
            get
            {
                return this.instructionalTextML.Value;
            }
        }

        public bool? LinksAllowed
        {
            get
            {
                return this.linksAllowed.Value;
            }
            set
            {
                this.linksAllowed.Value = value;
            }
        }

        public bool? ModifyAllowed
        {
            get
            {
                return this.modifyAllowed.Value;
            }
            set
            {
                this.modifyAllowed.Value = value;
            }
        }

        public bool? MultipleNewLines
        {
            get
            {
                return this.multipleNewLines.Value;
            }
            set
            {
                this.multipleNewLines.Value = value;
            }
        }

#if NAV2018
        public FieldList ODataKeyFields => odataKeyFields.Value;
#endif

        public Trigger OnAfterGetCurrRecord
        {
            get
            {
                return this.onAfterGetCurrRecord.Value;
            }
        }

        public Trigger OnAfterGetRecord
        {
            get
            {
                return this.onAfterGetRecord.Value;
            }
        }

        public Trigger OnClosePage
        {
            get
            {
                return this.onClosePage.Value;
            }
        }

        public Trigger OnDeleteRecord
        {
            get
            {
                return this.onDeleteRecord.Value;
            }
        }

        public Trigger OnFindRecord
        {
            get
            {
                return this.onFindRecord.Value;
            }
        }

        public Trigger OnInit
        {
            get
            {
                return this.onInit.Value;
            }
        }

        public Trigger OnInsertRecord
        {
            get
            {
                return this.onInsertRecord.Value;
            }
        }

        public Trigger OnModifyRecord
        {
            get
            {
                return this.onModifyRecord.Value;
            }
        }

        public Trigger OnNewRecord
        {
            get
            {
                return this.onNewRecord.Value;
            }
        }

        public Trigger OnNextRecord
        {
            get
            {
                return this.onNextRecord.Value;
            }
        }

        public Trigger OnOpenPage
        {
            get
            {
                return this.onOpenPage.Value;
            }
        }

        public Trigger OnQueryClosePage
        {
            get
            {
                return this.onQueryClosePage.Value;
            }
        }

        public PageType? PageType
        {
            get
            {
                return this.pageType.Value;
            }
            set
            {
                this.pageType.Value = value;
            }
        }

        public Permissions Permissions
        {
            get
            {
                return this.permissions.Value;
            }
        }

        public bool? PopulateAllFields
        {
            get
            {
                return this.populateAllFields.Value;
            }
            set
            {
                this.populateAllFields.Value = value;
            }
        }

        public MultiLanguageValue PromotedActionCategoriesML
        {
            get
            {
                return this.promotedActionCategoriesML.Value;
            }
        }

        public bool? RefreshOnActivate
        {
            get
            {
                return this.refreshOnActivate.Value;
            }
            set
            {
                this.refreshOnActivate.Value = value;
            }
        }

        public bool? SaveValues
        {
            get
            {
                return this.saveValues.Value;
            }
            set
            {
                this.saveValues.Value = value;
            }
        }

        public bool? ShowFilter
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

        public int? SourceTable
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

        public bool? SourceTableTemporary
        {
            get
            {
                return this.sourceTableTemporary.Value;
            }
            set
            {
                this.sourceTableTemporary.Value = value;
            }
        }

        public TableView SourceTableView
        {
            get
            {
                return this.sourceTableView.Value;
            }
        }
    }
}