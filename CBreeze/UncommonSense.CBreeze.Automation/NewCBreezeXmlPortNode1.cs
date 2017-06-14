﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Management.Automation;
using UncommonSense.CBreeze.Common;
using UncommonSense.CBreeze.Core;

namespace UncommonSense.CBreeze.Automation 
{
	[Cmdlet(VerbsCommon.New, "CBreezeXmlPortFieldAttribute", DefaultParameterSetName=ParameterSetNames.NewWithoutID)]
	[OutputType(typeof(XmlPortNode))]
	[Alias("FieldAttribute")]
	public class NewCBreezeXmlPortFieldAttribute : NewItemWithIDAndNameCmdlet<XmlPortNode, Guid, PSObject>
	{
		protected override IEnumerable<XmlPortNode> CreateItems()
		{
			var xmlPortFieldAttribute = new XmlPortFieldAttribute(Name, GetIndentation(), ID);

			xmlPortFieldAttribute.Properties.AutoCalcField = AutoCalcField;
			xmlPortFieldAttribute.Properties.DataType = DataType;
			xmlPortFieldAttribute.Properties.FieldValidate = FieldValidate;
			xmlPortFieldAttribute.Properties.Occurrence = Occurrence;
			xmlPortFieldAttribute.Properties.SourceField.FieldName = SourceFieldName;
			xmlPortFieldAttribute.Properties.SourceField.TableVariableName = SourceFieldTableVariableName;
			xmlPortFieldAttribute.Properties.Width = Width;

			yield return xmlPortFieldAttribute;

			if (ChildNodes != null)
			{
                var variables = new List<PSVariable>() { new PSVariable("Indentation", GetIndentation() + 1) };
				var childNodes = ChildNodes.InvokeWithContext(null, variables).Select(c => c.BaseObject).Cast<XmlPortNode>();

				foreach(var childNode in childNodes)
				{
					yield return childNode;
				}
			}
		}

		protected override void AddItemToInputObject(XmlPortNode item, PSObject inputObject)
		{
			if (InputObject.BaseObject is XmlPort)
			{
				switch(Position.GetValueOrDefault(Core.Position.LastWithinContainer))
				{
					case Core.Position.FirstWithinContainer: (InputObject.BaseObject as XmlPort).Nodes.Insert(0, item); break;
					case Core.Position.LastWithinContainer: (InputObject.BaseObject as XmlPort).Nodes.Add(item); break;
				}
			}
			else if (InputObject.BaseObject is XmlPortNodes)
			{
				switch(Position.GetValueOrDefault(Core.Position.LastWithinContainer))
				{
					case Core.Position.FirstWithinContainer: (InputObject.BaseObject as XmlPortNodes).Insert(0, item); break;
					case Core.Position.LastWithinContainer: (InputObject.BaseObject as XmlPortNodes).Add(item); break;
				}
			}
			else if (InputObject.BaseObject is XmlPortNode)
			{
				(InputObject.BaseObject as XmlPortNode).AddChildNode(item, Position.GetValueOrDefault(Core.Position.LastWithinContainer));
			}
			else
			{
				throw new ArgumentOutOfRangeException("Don't know how to add an XmlPort node to this InputObject.");
			}
		}

		protected int GetIndentation()
		{
			switch(ParameterSetName)
			{
				case ParameterSetNames.AddWithID:
				case ParameterSetNames.AddWithoutID:
					if (InputObject.BaseObject is XmlPort) { return 0; }
					if (InputObject.BaseObject is XmlPortNodes) { return 0; } 
					if (InputObject.BaseObject is XmlPortNode) { return (InputObject.BaseObject as XmlPortNode).IndentationLevel.GetValueOrDefault(0) + 1; };
	                throw new ArgumentOutOfRangeException("Cannot determine indentation.");
					
				case ParameterSetNames.NewWithID:
				case ParameterSetNames.NewWithoutID:
					return (int)GetVariableValue("Indentation", 0);

				default: 
					return 0;
			}
		}

		[Parameter()]
		public Position? Position { get; set; }
		
		[Parameter()]
		public Nullable<Boolean> AutoCalcField { get; set; }

		[Parameter()]
		public Nullable<XmlPortNodeDataType> DataType { get; set; }

		[Parameter()]
		public Nullable<Boolean> FieldValidate { get; set; }

		[Parameter()]
		public Nullable<Occurrence> Occurrence { get; set; }

		[Parameter(Mandatory = true, Position = 3, ParameterSetName=ParameterSetNames.NewWithoutID)]
		[Parameter(Mandatory = true, Position = 4, ParameterSetName=ParameterSetNames.NewWithID)]
		[Parameter(Mandatory = true, Position = 3, ParameterSetName=ParameterSetNames.AddWithoutID)]
		[Parameter(Mandatory = true, Position = 4, ParameterSetName=ParameterSetNames.AddWithID)]		
		public string SourceFieldName { get; set; }

		[Parameter(Mandatory = true, Position = 2, ParameterSetName=ParameterSetNames.NewWithoutID)]
		[Parameter(Mandatory = true, Position = 3, ParameterSetName=ParameterSetNames.NewWithID)]
		[Parameter(Mandatory = true, Position = 2, ParameterSetName=ParameterSetNames.AddWithoutID)]
		[Parameter(Mandatory = true, Position = 3, ParameterSetName=ParameterSetNames.AddWithID)]		
		public string SourceFieldTableVariableName { get; set; }

		[Parameter()]
		public Nullable<Int32> Width { get; set; }

        [Parameter(Position = 4, ParameterSetName = ParameterSetNames.AddWithoutID)]
        [Parameter(Position = 4, ParameterSetName = ParameterSetNames.NewWithoutID)]
        [Parameter(Position = 5, ParameterSetName = ParameterSetNames.AddWithID)]
        [Parameter(Position = 5, ParameterSetName = ParameterSetNames.NewWithID)]
		public ScriptBlock ChildNodes { get; set; }
	}

	[Cmdlet(VerbsCommon.New, "CBreezeXmlPortFieldElement", DefaultParameterSetName=ParameterSetNames.NewWithoutID)]
	[OutputType(typeof(XmlPortNode))]
	[Alias("FieldElement")]
	public class NewCBreezeXmlPortFieldElement : NewItemWithIDAndNameCmdlet<XmlPortNode, Guid, PSObject>
	{
		protected override IEnumerable<XmlPortNode> CreateItems()
		{
			var xmlPortFieldElement = new XmlPortFieldElement(Name, GetIndentation(), ID);

			xmlPortFieldElement.Properties.AutoCalcField = AutoCalcField;
			xmlPortFieldElement.Properties.DataType = DataType;
			xmlPortFieldElement.Properties.FieldValidate = FieldValidate;
			xmlPortFieldElement.Properties.MaxOccurs = MaxOccurs;
			xmlPortFieldElement.Properties.MinOccurs = MinOccurs;
			xmlPortFieldElement.Properties.NamespacePrefix = NamespacePrefix;
			xmlPortFieldElement.Properties.SourceField.FieldName = SourceFieldName;
			xmlPortFieldElement.Properties.SourceField.TableVariableName = SourceFieldTableVariableName;
			xmlPortFieldElement.Properties.Unbound = Unbound;
			xmlPortFieldElement.Properties.Width = Width;

			yield return xmlPortFieldElement;

			if (ChildNodes != null)
			{
                var variables = new List<PSVariable>() { new PSVariable("Indentation", GetIndentation() + 1) };
				var childNodes = ChildNodes.InvokeWithContext(null, variables).Select(c => c.BaseObject).Cast<XmlPortNode>();

				foreach(var childNode in childNodes)
				{
					yield return childNode;
				}
			}
		}

		protected override void AddItemToInputObject(XmlPortNode item, PSObject inputObject)
		{
			if (InputObject.BaseObject is XmlPort)
			{
				switch(Position.GetValueOrDefault(Core.Position.LastWithinContainer))
				{
					case Core.Position.FirstWithinContainer: (InputObject.BaseObject as XmlPort).Nodes.Insert(0, item); break;
					case Core.Position.LastWithinContainer: (InputObject.BaseObject as XmlPort).Nodes.Add(item); break;
				}
			}
			else if (InputObject.BaseObject is XmlPortNodes)
			{
				switch(Position.GetValueOrDefault(Core.Position.LastWithinContainer))
				{
					case Core.Position.FirstWithinContainer: (InputObject.BaseObject as XmlPortNodes).Insert(0, item); break;
					case Core.Position.LastWithinContainer: (InputObject.BaseObject as XmlPortNodes).Add(item); break;
				}
			}
			else if (InputObject.BaseObject is XmlPortNode)
			{
				(InputObject.BaseObject as XmlPortNode).AddChildNode(item, Position.GetValueOrDefault(Core.Position.LastWithinContainer));
			}
			else
			{
				throw new ArgumentOutOfRangeException("Don't know how to add an XmlPort node to this InputObject.");
			}
		}

		protected int GetIndentation()
		{
			switch(ParameterSetName)
			{
				case ParameterSetNames.AddWithID:
				case ParameterSetNames.AddWithoutID:
					if (InputObject.BaseObject is XmlPort) { return 0; }
					if (InputObject.BaseObject is XmlPortNodes) { return 0; } 
					if (InputObject.BaseObject is XmlPortNode) { return (InputObject.BaseObject as XmlPortNode).IndentationLevel.GetValueOrDefault(0) + 1; };
	                throw new ArgumentOutOfRangeException("Cannot determine indentation.");
					
				case ParameterSetNames.NewWithID:
				case ParameterSetNames.NewWithoutID:
					return (int)GetVariableValue("Indentation", 0);

				default: 
					return 0;
			}
		}

		[Parameter()]
		public Position? Position { get; set; }
		
		[Parameter()]
		public Nullable<Boolean> AutoCalcField { get; set; }

		[Parameter()]
		public Nullable<XmlPortNodeDataType> DataType { get; set; }

		[Parameter()]
		public Nullable<Boolean> FieldValidate { get; set; }

		[Parameter()]
		public Nullable<MaxOccurs> MaxOccurs { get; set; }

		[Parameter()]
		public Nullable<MinOccurs> MinOccurs { get; set; }

		[Parameter()]
		public String NamespacePrefix { get; set; }

		[Parameter(Mandatory = true, Position = 3, ParameterSetName=ParameterSetNames.NewWithoutID)]
		[Parameter(Mandatory = true, Position = 4, ParameterSetName=ParameterSetNames.NewWithID)]
		[Parameter(Mandatory = true, Position = 3, ParameterSetName=ParameterSetNames.AddWithoutID)]
		[Parameter(Mandatory = true, Position = 4, ParameterSetName=ParameterSetNames.AddWithID)]		
		public string SourceFieldName { get; set; }

		[Parameter(Mandatory = true, Position = 2, ParameterSetName=ParameterSetNames.NewWithoutID)]
		[Parameter(Mandatory = true, Position = 3, ParameterSetName=ParameterSetNames.NewWithID)]
		[Parameter(Mandatory = true, Position = 2, ParameterSetName=ParameterSetNames.AddWithoutID)]
		[Parameter(Mandatory = true, Position = 3, ParameterSetName=ParameterSetNames.AddWithID)]		
		public string SourceFieldTableVariableName { get; set; }

		[Parameter()]
		public Nullable<Boolean> Unbound { get; set; }

		[Parameter()]
		public Nullable<Int32> Width { get; set; }

        [Parameter(Position = 4, ParameterSetName = ParameterSetNames.AddWithoutID)]
        [Parameter(Position = 4, ParameterSetName = ParameterSetNames.NewWithoutID)]
        [Parameter(Position = 5, ParameterSetName = ParameterSetNames.AddWithID)]
        [Parameter(Position = 5, ParameterSetName = ParameterSetNames.NewWithID)]
		public ScriptBlock ChildNodes { get; set; }
	}

	[Cmdlet(VerbsCommon.New, "CBreezeXmlPortTableAttribute", DefaultParameterSetName=ParameterSetNames.NewWithoutID)]
	[OutputType(typeof(XmlPortNode))]
	[Alias("TableAttribute")]
	public class NewCBreezeXmlPortTableAttribute : NewItemWithIDAndNameCmdlet<XmlPortNode, Guid, PSObject>
	{
		protected override IEnumerable<XmlPortNode> CreateItems()
		{
			var xmlPortTableAttribute = new XmlPortTableAttribute(Name, GetIndentation(), ID);

			xmlPortTableAttribute.Properties.AutoReplace = AutoReplace;
			xmlPortTableAttribute.Properties.AutoSave = AutoSave;
			xmlPortTableAttribute.Properties.AutoUpdate = AutoUpdate;
			xmlPortTableAttribute.Properties.CalcFields.AddRange(CalcFields);
			xmlPortTableAttribute.Properties.LinkTable = LinkTable;
			xmlPortTableAttribute.Properties.LinkTableForceInsert = LinkTableForceInsert;
			xmlPortTableAttribute.Properties.Occurrence = Occurrence;
			xmlPortTableAttribute.Properties.ReqFilterFields.AddRange(ReqFilterFields);
			xmlPortTableAttribute.Properties.SourceTable = SourceTable;
			xmlPortTableAttribute.Properties.SourceTableView.Key = SourceTableViewKey;
			xmlPortTableAttribute.Properties.SourceTableView.Order = SourceTableViewOrder;
			xmlPortTableAttribute.Properties.Temporary = Temporary;
			xmlPortTableAttribute.Properties.VariableName = VariableName;
			xmlPortTableAttribute.Properties.Width = Width;

			yield return xmlPortTableAttribute;

			if (ChildNodes != null)
			{
                var variables = new List<PSVariable>() { new PSVariable("Indentation", GetIndentation() + 1) };
				var childNodes = ChildNodes.InvokeWithContext(null, variables).Select(c => c.BaseObject).Cast<XmlPortNode>();

				foreach(var childNode in childNodes)
				{
					yield return childNode;
				}
			}
		}

		protected override void AddItemToInputObject(XmlPortNode item, PSObject inputObject)
		{
			if (InputObject.BaseObject is XmlPort)
			{
				switch(Position.GetValueOrDefault(Core.Position.LastWithinContainer))
				{
					case Core.Position.FirstWithinContainer: (InputObject.BaseObject as XmlPort).Nodes.Insert(0, item); break;
					case Core.Position.LastWithinContainer: (InputObject.BaseObject as XmlPort).Nodes.Add(item); break;
				}
			}
			else if (InputObject.BaseObject is XmlPortNodes)
			{
				switch(Position.GetValueOrDefault(Core.Position.LastWithinContainer))
				{
					case Core.Position.FirstWithinContainer: (InputObject.BaseObject as XmlPortNodes).Insert(0, item); break;
					case Core.Position.LastWithinContainer: (InputObject.BaseObject as XmlPortNodes).Add(item); break;
				}
			}
			else if (InputObject.BaseObject is XmlPortNode)
			{
				(InputObject.BaseObject as XmlPortNode).AddChildNode(item, Position.GetValueOrDefault(Core.Position.LastWithinContainer));
			}
			else
			{
				throw new ArgumentOutOfRangeException("Don't know how to add an XmlPort node to this InputObject.");
			}
		}

		protected int GetIndentation()
		{
			switch(ParameterSetName)
			{
				case ParameterSetNames.AddWithID:
				case ParameterSetNames.AddWithoutID:
					if (InputObject.BaseObject is XmlPort) { return 0; }
					if (InputObject.BaseObject is XmlPortNodes) { return 0; } 
					if (InputObject.BaseObject is XmlPortNode) { return (InputObject.BaseObject as XmlPortNode).IndentationLevel.GetValueOrDefault(0) + 1; };
	                throw new ArgumentOutOfRangeException("Cannot determine indentation.");
					
				case ParameterSetNames.NewWithID:
				case ParameterSetNames.NewWithoutID:
					return (int)GetVariableValue("Indentation", 0);

				default: 
					return 0;
			}
		}

		[Parameter()]
		public Position? Position { get; set; }
		
		[Parameter()]
		public Nullable<Boolean> AutoReplace { get; set; }

		[Parameter()]
		public Nullable<Boolean> AutoSave { get; set; }

		[Parameter()]
		public Nullable<Boolean> AutoUpdate { get; set; }

		[Parameter()]
		public string[] CalcFields { get; set; }

		[Parameter()]
		public String LinkTable { get; set; }

		[Parameter()]
		public Nullable<Boolean> LinkTableForceInsert { get; set; }

		[Parameter()]
		public Nullable<Occurrence> Occurrence { get; set; }

		[Parameter()]
		public string[] ReqFilterFields { get; set; }

		[Parameter(Mandatory = true, Position = 2, ParameterSetName=ParameterSetNames.NewWithoutID)]
		[Parameter(Mandatory = true, Position = 3, ParameterSetName=ParameterSetNames.NewWithID)]
		[Parameter(Mandatory = true, Position = 2, ParameterSetName=ParameterSetNames.AddWithoutID)]
		[Parameter(Mandatory = true, Position = 3, ParameterSetName=ParameterSetNames.AddWithID)]		
		[ValidateRange(1, int.MaxValue)]
		public Nullable<Int32> SourceTable { get; set; }

		[Parameter()]
		public string SourceTableViewKey { get; set; }

		[Parameter()]
		public Order? SourceTableViewOrder { get; set; }

		[Parameter()]
		public Nullable<Boolean> Temporary { get; set; }

		[Parameter()]
		public String VariableName { get; set; }

		[Parameter()]
		public Nullable<Int32> Width { get; set; }

        [Parameter(Position = 3, ParameterSetName = ParameterSetNames.AddWithoutID)]
        [Parameter(Position = 3, ParameterSetName = ParameterSetNames.NewWithoutID)]
        [Parameter(Position = 4, ParameterSetName = ParameterSetNames.AddWithID)]
        [Parameter(Position = 4, ParameterSetName = ParameterSetNames.NewWithID)]
		public ScriptBlock ChildNodes { get; set; }
	}

	[Cmdlet(VerbsCommon.New, "CBreezeXmlPortTableElement", DefaultParameterSetName=ParameterSetNames.NewWithoutID)]
	[OutputType(typeof(XmlPortNode))]
	[Alias("TableElement")]
	public class NewCBreezeXmlPortTableElement : NewItemWithIDAndNameCmdlet<XmlPortNode, Guid, PSObject>
	{
		protected override IEnumerable<XmlPortNode> CreateItems()
		{
			var xmlPortTableElement = new XmlPortTableElement(Name, GetIndentation(), ID);

			xmlPortTableElement.Properties.AutoReplace = AutoReplace;
			xmlPortTableElement.Properties.AutoSave = AutoSave;
			xmlPortTableElement.Properties.AutoUpdate = AutoUpdate;
			xmlPortTableElement.Properties.CalcFields.AddRange(CalcFields);
			xmlPortTableElement.Properties.LinkTable = LinkTable;
			xmlPortTableElement.Properties.LinkTableForceInsert = LinkTableForceInsert;
			xmlPortTableElement.Properties.MaxOccurs = MaxOccurs;
			xmlPortTableElement.Properties.MinOccurs = MinOccurs;
			xmlPortTableElement.Properties.NamespacePrefix = NamespacePrefix;
			xmlPortTableElement.Properties.ReqFilterFields.AddRange(ReqFilterFields);
			xmlPortTableElement.Properties.SourceTable = SourceTable;
			xmlPortTableElement.Properties.SourceTableView.Key = SourceTableViewKey;
			xmlPortTableElement.Properties.SourceTableView.Order = SourceTableViewOrder;
			xmlPortTableElement.Properties.Temporary = Temporary;
			xmlPortTableElement.Properties.VariableName = VariableName;
			xmlPortTableElement.Properties.Width = Width;

			yield return xmlPortTableElement;

			if (ChildNodes != null)
			{
                var variables = new List<PSVariable>() { new PSVariable("Indentation", GetIndentation() + 1) };
				var childNodes = ChildNodes.InvokeWithContext(null, variables).Select(c => c.BaseObject).Cast<XmlPortNode>();

				foreach(var childNode in childNodes)
				{
					yield return childNode;
				}
			}
		}

		protected override void AddItemToInputObject(XmlPortNode item, PSObject inputObject)
		{
			if (InputObject.BaseObject is XmlPort)
			{
				switch(Position.GetValueOrDefault(Core.Position.LastWithinContainer))
				{
					case Core.Position.FirstWithinContainer: (InputObject.BaseObject as XmlPort).Nodes.Insert(0, item); break;
					case Core.Position.LastWithinContainer: (InputObject.BaseObject as XmlPort).Nodes.Add(item); break;
				}
			}
			else if (InputObject.BaseObject is XmlPortNodes)
			{
				switch(Position.GetValueOrDefault(Core.Position.LastWithinContainer))
				{
					case Core.Position.FirstWithinContainer: (InputObject.BaseObject as XmlPortNodes).Insert(0, item); break;
					case Core.Position.LastWithinContainer: (InputObject.BaseObject as XmlPortNodes).Add(item); break;
				}
			}
			else if (InputObject.BaseObject is XmlPortNode)
			{
				(InputObject.BaseObject as XmlPortNode).AddChildNode(item, Position.GetValueOrDefault(Core.Position.LastWithinContainer));
			}
			else
			{
				throw new ArgumentOutOfRangeException("Don't know how to add an XmlPort node to this InputObject.");
			}
		}

		protected int GetIndentation()
		{
			switch(ParameterSetName)
			{
				case ParameterSetNames.AddWithID:
				case ParameterSetNames.AddWithoutID:
					if (InputObject.BaseObject is XmlPort) { return 0; }
					if (InputObject.BaseObject is XmlPortNodes) { return 0; } 
					if (InputObject.BaseObject is XmlPortNode) { return (InputObject.BaseObject as XmlPortNode).IndentationLevel.GetValueOrDefault(0) + 1; };
	                throw new ArgumentOutOfRangeException("Cannot determine indentation.");
					
				case ParameterSetNames.NewWithID:
				case ParameterSetNames.NewWithoutID:
					return (int)GetVariableValue("Indentation", 0);

				default: 
					return 0;
			}
		}

		[Parameter()]
		public Position? Position { get; set; }
		
		[Parameter()]
		public Nullable<Boolean> AutoReplace { get; set; }

		[Parameter()]
		public Nullable<Boolean> AutoSave { get; set; }

		[Parameter()]
		public Nullable<Boolean> AutoUpdate { get; set; }

		[Parameter()]
		public string[] CalcFields { get; set; }

		[Parameter()]
		public String LinkTable { get; set; }

		[Parameter()]
		public Nullable<Boolean> LinkTableForceInsert { get; set; }

		[Parameter()]
		public Nullable<MaxOccurs> MaxOccurs { get; set; }

		[Parameter()]
		public Nullable<MinOccurs> MinOccurs { get; set; }

		[Parameter()]
		public String NamespacePrefix { get; set; }

		[Parameter()]
		public string[] ReqFilterFields { get; set; }

		[Parameter(Mandatory = true, Position = 2, ParameterSetName=ParameterSetNames.NewWithoutID)]
		[Parameter(Mandatory = true, Position = 3, ParameterSetName=ParameterSetNames.NewWithID)]
		[Parameter(Mandatory = true, Position = 2, ParameterSetName=ParameterSetNames.AddWithoutID)]
		[Parameter(Mandatory = true, Position = 3, ParameterSetName=ParameterSetNames.AddWithID)]		
		[ValidateRange(1, int.MaxValue)]
		public Nullable<Int32> SourceTable { get; set; }

		[Parameter()]
		public string SourceTableViewKey { get; set; }

		[Parameter()]
		public Order? SourceTableViewOrder { get; set; }

		[Parameter()]
		public Nullable<Boolean> Temporary { get; set; }

		[Parameter()]
		public String VariableName { get; set; }

		[Parameter()]
		public Nullable<Int32> Width { get; set; }

        [Parameter(Position = 3, ParameterSetName = ParameterSetNames.AddWithoutID)]
        [Parameter(Position = 3, ParameterSetName = ParameterSetNames.NewWithoutID)]
        [Parameter(Position = 4, ParameterSetName = ParameterSetNames.AddWithID)]
        [Parameter(Position = 4, ParameterSetName = ParameterSetNames.NewWithID)]
		public ScriptBlock ChildNodes { get; set; }
	}

	[Cmdlet(VerbsCommon.New, "CBreezeXmlPortTextAttribute", DefaultParameterSetName=ParameterSetNames.NewWithoutID)]
	[OutputType(typeof(XmlPortNode))]
	[Alias("TextAttribute")]
	public class NewCBreezeXmlPortTextAttribute : NewItemWithIDAndNameCmdlet<XmlPortNode, Guid, PSObject>
	{
		protected override IEnumerable<XmlPortNode> CreateItems()
		{
			var xmlPortTextAttribute = new XmlPortTextAttribute(Name, GetIndentation(), ID);

			xmlPortTextAttribute.Properties.DataType = DataType;
			xmlPortTextAttribute.Properties.Occurrence = Occurrence;
			xmlPortTextAttribute.Properties.TextType = TextType;
			xmlPortTextAttribute.Properties.VariableName = VariableName;
			xmlPortTextAttribute.Properties.Width = Width;

			yield return xmlPortTextAttribute;

			if (ChildNodes != null)
			{
                var variables = new List<PSVariable>() { new PSVariable("Indentation", GetIndentation() + 1) };
				var childNodes = ChildNodes.InvokeWithContext(null, variables).Select(c => c.BaseObject).Cast<XmlPortNode>();

				foreach(var childNode in childNodes)
				{
					yield return childNode;
				}
			}
		}

		protected override void AddItemToInputObject(XmlPortNode item, PSObject inputObject)
		{
			if (InputObject.BaseObject is XmlPort)
			{
				switch(Position.GetValueOrDefault(Core.Position.LastWithinContainer))
				{
					case Core.Position.FirstWithinContainer: (InputObject.BaseObject as XmlPort).Nodes.Insert(0, item); break;
					case Core.Position.LastWithinContainer: (InputObject.BaseObject as XmlPort).Nodes.Add(item); break;
				}
			}
			else if (InputObject.BaseObject is XmlPortNodes)
			{
				switch(Position.GetValueOrDefault(Core.Position.LastWithinContainer))
				{
					case Core.Position.FirstWithinContainer: (InputObject.BaseObject as XmlPortNodes).Insert(0, item); break;
					case Core.Position.LastWithinContainer: (InputObject.BaseObject as XmlPortNodes).Add(item); break;
				}
			}
			else if (InputObject.BaseObject is XmlPortNode)
			{
				(InputObject.BaseObject as XmlPortNode).AddChildNode(item, Position.GetValueOrDefault(Core.Position.LastWithinContainer));
			}
			else
			{
				throw new ArgumentOutOfRangeException("Don't know how to add an XmlPort node to this InputObject.");
			}
		}

		protected int GetIndentation()
		{
			switch(ParameterSetName)
			{
				case ParameterSetNames.AddWithID:
				case ParameterSetNames.AddWithoutID:
					if (InputObject.BaseObject is XmlPort) { return 0; }
					if (InputObject.BaseObject is XmlPortNodes) { return 0; } 
					if (InputObject.BaseObject is XmlPortNode) { return (InputObject.BaseObject as XmlPortNode).IndentationLevel.GetValueOrDefault(0) + 1; };
	                throw new ArgumentOutOfRangeException("Cannot determine indentation.");
					
				case ParameterSetNames.NewWithID:
				case ParameterSetNames.NewWithoutID:
					return (int)GetVariableValue("Indentation", 0);

				default: 
					return 0;
			}
		}

		[Parameter()]
		public Position? Position { get; set; }
		
		[Parameter()]
		public Nullable<XmlPortNodeDataType> DataType { get; set; }

		[Parameter()]
		public Nullable<Occurrence> Occurrence { get; set; }

		[Parameter()]
		public Nullable<TextType> TextType { get; set; }

		[Parameter()]
		public String VariableName { get; set; }

		[Parameter()]
		public Nullable<Int32> Width { get; set; }

        [Parameter(Position = 2, ParameterSetName = ParameterSetNames.AddWithoutID)]
        [Parameter(Position = 2, ParameterSetName = ParameterSetNames.NewWithoutID)]
        [Parameter(Position = 3, ParameterSetName = ParameterSetNames.AddWithID)]
        [Parameter(Position = 3, ParameterSetName = ParameterSetNames.NewWithID)]
		public ScriptBlock ChildNodes { get; set; }
	}

	[Cmdlet(VerbsCommon.New, "CBreezeXmlPortTextElement", DefaultParameterSetName=ParameterSetNames.NewWithoutID)]
	[OutputType(typeof(XmlPortNode))]
	[Alias("TextElement")]
	public class NewCBreezeXmlPortTextElement : NewItemWithIDAndNameCmdlet<XmlPortNode, Guid, PSObject>
	{
		protected override IEnumerable<XmlPortNode> CreateItems()
		{
			var xmlPortTextElement = new XmlPortTextElement(Name, GetIndentation(), ID);

			xmlPortTextElement.Properties.DataType = DataType;
			xmlPortTextElement.Properties.MaxOccurs = MaxOccurs;
			xmlPortTextElement.Properties.MinOccurs = MinOccurs;
			xmlPortTextElement.Properties.NamespacePrefix = NamespacePrefix;
			xmlPortTextElement.Properties.TextType = TextType;
			xmlPortTextElement.Properties.Unbound = Unbound;
			xmlPortTextElement.Properties.VariableName = VariableName;
			xmlPortTextElement.Properties.Width = Width;

			yield return xmlPortTextElement;

			if (ChildNodes != null)
			{
                var variables = new List<PSVariable>() { new PSVariable("Indentation", GetIndentation() + 1) };
				var childNodes = ChildNodes.InvokeWithContext(null, variables).Select(c => c.BaseObject).Cast<XmlPortNode>();

				foreach(var childNode in childNodes)
				{
					yield return childNode;
				}
			}
		}

		protected override void AddItemToInputObject(XmlPortNode item, PSObject inputObject)
		{
			if (InputObject.BaseObject is XmlPort)
			{
				switch(Position.GetValueOrDefault(Core.Position.LastWithinContainer))
				{
					case Core.Position.FirstWithinContainer: (InputObject.BaseObject as XmlPort).Nodes.Insert(0, item); break;
					case Core.Position.LastWithinContainer: (InputObject.BaseObject as XmlPort).Nodes.Add(item); break;
				}
			}
			else if (InputObject.BaseObject is XmlPortNodes)
			{
				switch(Position.GetValueOrDefault(Core.Position.LastWithinContainer))
				{
					case Core.Position.FirstWithinContainer: (InputObject.BaseObject as XmlPortNodes).Insert(0, item); break;
					case Core.Position.LastWithinContainer: (InputObject.BaseObject as XmlPortNodes).Add(item); break;
				}
			}
			else if (InputObject.BaseObject is XmlPortNode)
			{
				(InputObject.BaseObject as XmlPortNode).AddChildNode(item, Position.GetValueOrDefault(Core.Position.LastWithinContainer));
			}
			else
			{
				throw new ArgumentOutOfRangeException("Don't know how to add an XmlPort node to this InputObject.");
			}
		}

		protected int GetIndentation()
		{
			switch(ParameterSetName)
			{
				case ParameterSetNames.AddWithID:
				case ParameterSetNames.AddWithoutID:
					if (InputObject.BaseObject is XmlPort) { return 0; }
					if (InputObject.BaseObject is XmlPortNodes) { return 0; } 
					if (InputObject.BaseObject is XmlPortNode) { return (InputObject.BaseObject as XmlPortNode).IndentationLevel.GetValueOrDefault(0) + 1; };
	                throw new ArgumentOutOfRangeException("Cannot determine indentation.");
					
				case ParameterSetNames.NewWithID:
				case ParameterSetNames.NewWithoutID:
					return (int)GetVariableValue("Indentation", 0);

				default: 
					return 0;
			}
		}

		[Parameter()]
		public Position? Position { get; set; }
		
		[Parameter()]
		public Nullable<XmlPortNodeDataType> DataType { get; set; }

		[Parameter()]
		public Nullable<MaxOccurs> MaxOccurs { get; set; }

		[Parameter()]
		public Nullable<MinOccurs> MinOccurs { get; set; }

		[Parameter()]
		public String NamespacePrefix { get; set; }

		[Parameter()]
		public Nullable<TextType> TextType { get; set; }

		[Parameter()]
		public Nullable<Boolean> Unbound { get; set; }

		[Parameter()]
		public String VariableName { get; set; }

		[Parameter()]
		public Nullable<Int32> Width { get; set; }

        [Parameter(Position = 2, ParameterSetName = ParameterSetNames.AddWithoutID)]
        [Parameter(Position = 2, ParameterSetName = ParameterSetNames.NewWithoutID)]
        [Parameter(Position = 3, ParameterSetName = ParameterSetNames.AddWithID)]
        [Parameter(Position = 3, ParameterSetName = ParameterSetNames.NewWithID)]
		public ScriptBlock ChildNodes { get; set; }
	}

}
