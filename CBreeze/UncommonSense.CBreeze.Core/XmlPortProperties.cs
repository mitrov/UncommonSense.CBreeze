using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class XmlPortProperties : IEnumerable<Property>
    {
        private List<Property> innerList = new List<Property>();

        private MultiLanguageProperty captionML = new MultiLanguageProperty("CaptionML");
        private NullableBooleanProperty defaultFieldsValidation = new NullableBooleanProperty("DefaultFieldsValidation");
        private StringProperty defaultNamespace = new StringProperty("DefaultNamespace");
        private DirectionProperty direction = new DirectionProperty("Direction");
        private XmlPortEncodingProperty encoding = new XmlPortEncodingProperty("Encoding");
        private StringProperty fieldDelimiter = new StringProperty("FieldDelimiter");
        private StringProperty fieldSeparator = new StringProperty("FieldSeparator");
        private StringProperty fileName = new StringProperty("FileName");
        private XmlPortFormatProperty format = new XmlPortFormatProperty("Format");
        private FormatEvaluateProperty formatEvaluate = new FormatEvaluateProperty("FormatEvaluate");
        private NullableBooleanProperty inlineSchema = new NullableBooleanProperty("InlineSchema");
        private TriggerProperty onInitXMLport = new TriggerProperty("OnInitXMLport");
        private TriggerProperty onPostXMLport = new TriggerProperty("OnPostXMLport");
        private TriggerProperty onPreXMLport = new TriggerProperty("OnPreXMLport");
        private PermissionsProperty permissions = new PermissionsProperty("Permissions");
        private NullableBooleanProperty preserveWhiteSpace = new NullableBooleanProperty("PreserveWhiteSpace");
        private StringProperty recordSeparator = new StringProperty("RecordSeparator");
        private StringProperty tableSeparator = new StringProperty("TableSeparator");
        private TextEncodingProperty textEncoding = new TextEncodingProperty("TextEncoding");
        private TransactionTypeProperty transactionType = new TransactionTypeProperty("TransactionType");
        private NullableBooleanProperty useDefaultNamespace = new NullableBooleanProperty("UseDefaultNamespace");
        private NullableBooleanProperty useLax = new NullableBooleanProperty("UseLax");
        private NullableBooleanProperty useRequestPage = new NullableBooleanProperty("UseRequestPage");
        private XmlVersionNoProperty xmlVersionNo = new XmlVersionNoProperty("XmlVersionNo");

        internal XmlPortProperties()
        {
            innerList.Add(permissions);
            innerList.Add(transactionType);
            innerList.Add(captionML);
            innerList.Add(direction);
            innerList.Add(encoding);
            innerList.Add(defaultFieldsValidation);
            innerList.Add(xmlVersionNo);
            innerList.Add(formatEvaluate);
            innerList.Add(preserveWhiteSpace);
            innerList.Add(defaultNamespace);
            innerList.Add(inlineSchema);
            innerList.Add(useDefaultNamespace);
            innerList.Add(onInitXMLport);
            innerList.Add(onPreXMLport);
            innerList.Add(onPostXMLport);
            innerList.Add(textEncoding);
            innerList.Add(format);
            innerList.Add(fieldDelimiter);
            innerList.Add(fieldSeparator);
            innerList.Add(recordSeparator);
            innerList.Add(tableSeparator);
            innerList.Add(useRequestPage);
            innerList.Add(useLax);
            innerList.Add(fileName);
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

      public System.Boolean? DefaultFieldsValidation
        {
            get
            {
                return this.defaultFieldsValidation.Value;
            }
            set
            {
                this.defaultFieldsValidation.Value = value;
            }
        }

      public System.String DefaultNamespace
        {
            get
            {
                return this.defaultNamespace.Value;
            }
            set
            {
                this.defaultNamespace.Value = value;
            }
        }

        public Direction? Direction
        {
            get
            {
                return this.direction.Value;
            }
            set
            {
                this.direction.Value = value;
            }
        }

        public XmlPortEncoding? Encoding
        {
            get
            {
                return this.encoding.Value;
            }
            set
            {
                this.encoding.Value = value;
            }
        }

      public System.String FieldDelimiter
        {
            get
            {
                return this.fieldDelimiter.Value;
            }
            set
            {
                this.fieldDelimiter.Value = value;
            }
        }

      public System.String FieldSeparator
        {
            get
            {
                return this.fieldSeparator.Value;
            }
            set
            {
                this.fieldSeparator.Value = value;
            }
        }

      public System.String FileName
        {
            get
            {
                return this.fileName.Value;
            }
            set
            {
                this.fileName.Value = value;
            }
        }

        public XmlPortFormat? Format
        {
            get
            {
                return this.format.Value;
            }
            set
            {
                this.format.Value = value;
            }
        }

        public FormatEvaluate? FormatEvaluate
        {
            get
            {
                return this.formatEvaluate.Value;
            }
            set
            {
                this.formatEvaluate.Value = value;
            }
        }

      public System.Boolean? InlineSchema
        {
            get
            {
                return this.inlineSchema.Value;
            }
            set
            {
                this.inlineSchema.Value = value;
            }
        }

        public Trigger OnInitXMLport
        {
            get
            {
                return this.onInitXMLport.Value;
            }
        }

        public Trigger OnPostXMLport
        {
            get
            {
                return this.onPostXMLport.Value;
            }
        }

        public Trigger OnPreXMLport
        {
            get
            {
                return this.onPreXMLport.Value;
            }
        }

        public Permissions Permissions
        {
            get
            {
                return this.permissions.Value;
            }
        }

      public System.Boolean? PreserveWhiteSpace
        {
            get
            {
                return this.preserveWhiteSpace.Value;
            }
            set
            {
                this.preserveWhiteSpace.Value = value;
            }
        }

      public System.String RecordSeparator
        {
            get
            {
                return this.recordSeparator.Value;
            }
            set
            {
                this.recordSeparator.Value = value;
            }
        }

      public System.String TableSeparator
        {
            get
            {
                return this.tableSeparator.Value;
            }
            set
            {
                this.tableSeparator.Value = value;
            }
        }

        public TextEncoding? TextEncoding
        {
            get
            {
                return this.textEncoding.Value;
            }
            set
            {
                this.textEncoding.Value = value;
            }
        }

        public TransactionType? TransactionType
        {
            get
            {
                return this.transactionType.Value;
            }
            set
            {
                this.transactionType.Value = value;
            }
        }

      public System.Boolean? UseDefaultNamespace
        {
            get
            {
                return this.useDefaultNamespace.Value;
            }
            set
            {
                this.useDefaultNamespace.Value = value;
            }
        }

      public System.Boolean? UseLax
        {
            get
            {
                return this.useLax.Value;
            }
            set
            {
                this.useLax.Value = value;
            }
        }

      public System.Boolean? UseRequestPage
        {
            get
            {
                return this.useRequestPage.Value;
            }
            set
            {
                this.useRequestPage.Value = value;
            }
        }

        public XmlVersionNo? XmlVersionNo
        {
            get
            {
                return this.xmlVersionNo.Value;
            }
            set
            {
                this.xmlVersionNo.Value = value;
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
