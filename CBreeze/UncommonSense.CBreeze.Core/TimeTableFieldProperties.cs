using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class TimeTableFieldProperties : IEnumerable<Property>
    {
        private List<Property> innerList = new List<Property>();

        private StringProperty altSearchField = new StringProperty("AltSearchField");
        private StringProperty autoFormatExpr = new StringProperty("AutoFormatExpr");
        private AutoFormatTypeProperty autoFormatType = new AutoFormatTypeProperty("AutoFormatType");
        private BlankNumbersProperty blankNumbers = new BlankNumbersProperty("BlankNumbers");
        private CalcFormulaProperty calcFormula = new CalcFormulaProperty("CalcFormula");
        private StringProperty captionClass = new StringProperty("CaptionClass");
        private MultiLanguageProperty captionML = new MultiLanguageProperty("CaptionML");
        private StringProperty description = new StringProperty("Description");
        private NullableBooleanProperty editable = new NullableBooleanProperty("Editable");
        private ExtendedDataTypeProperty extendedDatatype = new ExtendedDataTypeProperty("ExtendedDatatype");
        private FieldClassProperty fieldClass = new FieldClassProperty("FieldClass");
        private NullableTimeProperty initValue = new NullableTimeProperty("InitValue");
        private NullableTimeProperty maxValue = new NullableTimeProperty("MaxValue");
        private NullableTimeProperty minValue = new NullableTimeProperty("MinValue");
        private NullableBooleanProperty notBlank = new NullableBooleanProperty("NotBlank");
        private TriggerProperty onLookup = new TriggerProperty("OnLookup");
        private TriggerProperty onValidate = new TriggerProperty("OnValidate");
        private NullableIntegerProperty signDisplacement = new NullableIntegerProperty("SignDisplacement");
        private TableRelationLinesProperty tableRelation = new TableRelationLinesProperty("TableRelation");
        private NullableBooleanProperty testTableRelation = new NullableBooleanProperty("TestTableRelation");
        private NullableBooleanProperty validateTableRelation = new NullableBooleanProperty("ValidateTableRelation");
        private SemiColonSeparatedStringProperty valuesAllowed = new SemiColonSeparatedStringProperty("ValuesAllowed");

        internal TimeTableFieldProperties()
        {
            innerList.Add(fieldClass);
            innerList.Add(calcFormula);
            innerList.Add(initValue);
            innerList.Add(tableRelation);
            innerList.Add(altSearchField);
            innerList.Add(onValidate);
            innerList.Add(onLookup);
            innerList.Add(validateTableRelation);
            innerList.Add(testTableRelation);
            innerList.Add(extendedDatatype);
            innerList.Add(captionML);
            innerList.Add(minValue);
            innerList.Add(maxValue);
            innerList.Add(notBlank);
            innerList.Add(blankNumbers);
            innerList.Add(valuesAllowed);
            innerList.Add(signDisplacement);
            innerList.Add(description);
            innerList.Add(editable);
            innerList.Add(autoFormatType);
            innerList.Add(autoFormatExpr);
            innerList.Add(captionClass);
        }

        public Property this[string name]
        {
            get
            {
                return innerList.FirstOrDefault(p => p.Name == name);
            }
        }

      public System.String AltSearchField
        {
            get
            {
                return this.altSearchField.Value;
            }
            set
            {
                this.altSearchField.Value = value;
            }
        }

      public System.String AutoFormatExpr
        {
            get
            {
                return this.autoFormatExpr.Value;
            }
            set
            {
                this.autoFormatExpr.Value = value;
            }
        }

        public AutoFormatType? AutoFormatType
        {
            get
            {
                return this.autoFormatType.Value;
            }
            set
            {
                this.autoFormatType.Value = value;
            }
        }

        public BlankNumbers? BlankNumbers
        {
            get
            {
                return this.blankNumbers.Value;
            }
            set
            {
                this.blankNumbers.Value = value;
            }
        }

        public CalcFormula CalcFormula
        {
            get
            {
                return this.calcFormula.Value;
            }
        }

      public System.String CaptionClass
        {
            get
            {
                return this.captionClass.Value;
            }
            set
            {
                this.captionClass.Value = value;
            }
        }

        public MultiLanguageValue CaptionML
        {
            get
            {
                return this.captionML.Value;
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

      public System.Boolean? Editable
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

        public ExtendedDataType? ExtendedDatatype
        {
            get
            {
                return this.extendedDatatype.Value;
            }
            set
            {
                this.extendedDatatype.Value = value;
            }
        }

        public FieldClass? FieldClass
        {
            get
            {
                return this.fieldClass.Value;
            }
            set
            {
                this.fieldClass.Value = value;
            }
        }

      public System.TimeSpan? InitValue
        {
            get
            {
                return this.initValue.Value;
            }
            set
            {
                this.initValue.Value = value;
            }
        }

      public System.TimeSpan? MaxValue
        {
            get
            {
                return this.maxValue.Value;
            }
            set
            {
                this.maxValue.Value = value;
            }
        }

      public System.TimeSpan? MinValue
        {
            get
            {
                return this.minValue.Value;
            }
            set
            {
                this.minValue.Value = value;
            }
        }

      public System.Boolean? NotBlank
        {
            get
            {
                return this.notBlank.Value;
            }
            set
            {
                this.notBlank.Value = value;
            }
        }

        public Trigger OnLookup
        {
            get
            {
                return this.onLookup.Value;
            }
        }

        public Trigger OnValidate
        {
            get
            {
                return this.onValidate.Value;
            }
        }

      public System.Int32? SignDisplacement
        {
            get
            {
                return this.signDisplacement.Value;
            }
            set
            {
                this.signDisplacement.Value = value;
            }
        }

        public TableRelationLines TableRelation
        {
            get
            {
                return this.tableRelation.Value;
            }
        }

      public System.Boolean? TestTableRelation
        {
            get
            {
                return this.testTableRelation.Value;
            }
            set
            {
                this.testTableRelation.Value = value;
            }
        }

      public System.Boolean? ValidateTableRelation
        {
            get
            {
                return this.validateTableRelation.Value;
            }
            set
            {
                this.validateTableRelation.Value = value;
            }
        }

      public System.String ValuesAllowed
        {
            get
            {
                return this.valuesAllowed.Value;
            }
            set
            {
                this.valuesAllowed.Value = value;
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
