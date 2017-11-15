﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Management.Automation;
using System.Collections.Generic;
using UncommonSense.CBreeze.Common;
using UncommonSense.CBreeze.Core;

namespace UncommonSense.CBreeze.Automation 
{
	[Cmdlet(VerbsCommon.New, "CBreezeFunction")]
	[OutputType(typeof(Function))]
	[Alias("Procedure", "Add-CBreezeFunction")]
	public class NewCBreezeFunction : NewItemWithIDAndNameCmdlet<Function, int, PSObject>
	{
		[Parameter()] public SwitchParameter Local { get;set; }
		[Parameter()] public string ReturnValueName { get; set; } 
		[Parameter()] public FunctionReturnValueType? ReturnValueType { get; set; }
		[Parameter()] [ValidateRange(1, int.MaxValue)] public int? ReturnValueDataLength { get; set; }
		[Parameter()] public string ReturnValueDimensions { get; set; }

		[Parameter(Position = 2, ParameterSetName = ParameterSetNames.NewWithoutID)]
        [Parameter(Position = 3, ParameterSetName = ParameterSetNames.NewWithID)]
        [Parameter(Position = 2, ParameterSetName = ParameterSetNames.AddWithoutID)]
        [Parameter(Position = 3, ParameterSetName = ParameterSetNames.AddWithID)]
		public ScriptBlock SubObjects { get; set; }

#if NAV2016
		[Parameter()] public SwitchParameter TryFunction { get; set; }
#endif 

		protected override void AddItemToInputObject(Function item, PSObject inputObject)
		{
			GetFunctions(inputObject).Add(item);	
		}

		protected Functions GetFunctions(PSObject inputObject)
		{
			if (inputObject.BaseObject is Functions)
				return (inputObject.BaseObject as Functions);
			if (inputObject.BaseObject is Code)
				return (inputObject.BaseObject as Code).Functions;
			if (inputObject.BaseObject is Table)
				return (inputObject.BaseObject as Table).Code.Functions;
			if (inputObject.BaseObject is Page)
				return (inputObject.BaseObject as Page).Code.Functions;
			if (inputObject.BaseObject is Report)
				return (inputObject.BaseObject as Report).Code.Functions;
			if (inputObject.BaseObject is Codeunit)
				return (inputObject.BaseObject as Codeunit).Code.Functions;
			if (inputObject.BaseObject is Query)
				return (inputObject.BaseObject as Query).Code.Functions;
			if (inputObject.BaseObject is XmlPort)
				return (inputObject.BaseObject as XmlPort).Code.Functions;

			throw new ApplicationException("Cannot add functions to this type of object.");
		}

		protected override IEnumerable<Function> CreateItems()
		{
			var function = new Function(ID, Name);

			function.Local = Local;
#if NAV2016
			function.TryFunction = NullableBooleanFromSwitch(nameof(TryFunction));
#endif
			function.ReturnValue.Name = ReturnValueName;
			function.ReturnValue.Type = ReturnValueType;
			function.ReturnValue.DataLength = ReturnValueDataLength ?? function.ReturnValue.DefaultDataLength;
			function.ReturnValue.Dimensions = ReturnValueDimensions;

			
			if (SubObjects != null)
			{
				var subObjects = SubObjects
					.Invoke()
					.Select(o => o.BaseObject);

				function.Variables.AddRange(subObjects.OfType<Variable>());
				function.Parameters.AddRange(subObjects.OfType<Parameter>());
				function.CodeLines.AddRange(subObjects.OfType<string>());
			}

			yield return function;
		}		
	}

	[Cmdlet(VerbsCommon.New, "CBreezeTestFunction")]
	[OutputType(typeof(Function))]
	[Alias("TestFunction", "Add-CBreezeTestFunction")]
	public class NewCBreezeTestFunction : NewItemWithIDAndNameCmdlet<Function, int, PSObject>
	{
		[Parameter()] public SwitchParameter Local { get;set; }
		[Parameter()] public string ReturnValueName { get; set; } 
		[Parameter()] public FunctionReturnValueType? ReturnValueType { get; set; }
		[Parameter()] [ValidateRange(1, int.MaxValue)] public int? ReturnValueDataLength { get; set; }
		[Parameter()] public string ReturnValueDimensions { get; set; }

		[Parameter(Position = 2, ParameterSetName = ParameterSetNames.NewWithoutID)]
        [Parameter(Position = 3, ParameterSetName = ParameterSetNames.NewWithID)]
        [Parameter(Position = 2, ParameterSetName = ParameterSetNames.AddWithoutID)]
        [Parameter(Position = 3, ParameterSetName = ParameterSetNames.AddWithID)]
		public ScriptBlock SubObjects { get; set; }

#if NAV2016
		[Parameter()] public SwitchParameter TryFunction { get; set; }
#endif 
		[Parameter()] public string HandlerFunctions { get; set; }
		[Parameter()] public TestFunctionType? TestFunctionType { get; set; } 
		[Parameter()] public TransactionModel? TransactionModel { get; set; }

		protected override void AddItemToInputObject(Function item, PSObject inputObject)
		{
			GetFunctions(inputObject).Add(item);	
		}

		protected Functions GetFunctions(PSObject inputObject)
		{
			if (inputObject.BaseObject is Functions)
				return (inputObject.BaseObject as Functions);
			if (inputObject.BaseObject is Code)
				return (inputObject.BaseObject as Code).Functions;
			if (inputObject.BaseObject is Table)
				return (inputObject.BaseObject as Table).Code.Functions;
			if (inputObject.BaseObject is Page)
				return (inputObject.BaseObject as Page).Code.Functions;
			if (inputObject.BaseObject is Report)
				return (inputObject.BaseObject as Report).Code.Functions;
			if (inputObject.BaseObject is Codeunit)
				return (inputObject.BaseObject as Codeunit).Code.Functions;
			if (inputObject.BaseObject is Query)
				return (inputObject.BaseObject as Query).Code.Functions;
			if (inputObject.BaseObject is XmlPort)
				return (inputObject.BaseObject as XmlPort).Code.Functions;

			throw new ApplicationException("Cannot add functions to this type of object.");
		}

		protected override IEnumerable<Function> CreateItems()
		{
			var function = new Function(ID, Name);

			function.Local = Local;
#if NAV2016
			function.TryFunction = NullableBooleanFromSwitch(nameof(TryFunction));
#endif
			function.ReturnValue.Name = ReturnValueName;
			function.ReturnValue.Type = ReturnValueType;
			function.ReturnValue.DataLength = ReturnValueDataLength ?? function.ReturnValue.DefaultDataLength;
			function.ReturnValue.Dimensions = ReturnValueDimensions;

			function.HandlerFunctions = HandlerFunctions;
			function.TestFunctionType = TestFunctionType;
			function.TransactionModel = TransactionModel;
			
			if (SubObjects != null)
			{
				var subObjects = SubObjects
					.Invoke()
					.Select(o => o.BaseObject);

				function.Variables.AddRange(subObjects.OfType<Variable>());
				function.Parameters.AddRange(subObjects.OfType<Parameter>());
				function.CodeLines.AddRange(subObjects.OfType<string>());
			}

			yield return function;
		}		
	}

	[Cmdlet(VerbsCommon.New, "CBreezeUpgradeFunction")]
	[OutputType(typeof(Function))]
	[Alias("UpgradeFunction", "Add-CBreezeUpgradeFunction")]
	public class NewCBreezeUpgradeFunction : NewItemWithIDAndNameCmdlet<Function, int, PSObject>
	{
		[Parameter()] public SwitchParameter Local { get;set; }
		[Parameter()] public string ReturnValueName { get; set; } 
		[Parameter()] public FunctionReturnValueType? ReturnValueType { get; set; }
		[Parameter()] [ValidateRange(1, int.MaxValue)] public int? ReturnValueDataLength { get; set; }
		[Parameter()] public string ReturnValueDimensions { get; set; }

		[Parameter(Position = 2, ParameterSetName = ParameterSetNames.NewWithoutID)]
        [Parameter(Position = 3, ParameterSetName = ParameterSetNames.NewWithID)]
        [Parameter(Position = 2, ParameterSetName = ParameterSetNames.AddWithoutID)]
        [Parameter(Position = 3, ParameterSetName = ParameterSetNames.AddWithID)]
		public ScriptBlock SubObjects { get; set; }

#if NAV2016
		[Parameter()] public SwitchParameter TryFunction { get; set; }
#endif 
#if NAV2015
		[Parameter()] public UpgradeFunctionType? UpgradeFunctionType { get; set; } 
#endif

		protected override void AddItemToInputObject(Function item, PSObject inputObject)
		{
			GetFunctions(inputObject).Add(item);	
		}

		protected Functions GetFunctions(PSObject inputObject)
		{
			if (inputObject.BaseObject is Functions)
				return (inputObject.BaseObject as Functions);
			if (inputObject.BaseObject is Code)
				return (inputObject.BaseObject as Code).Functions;
			if (inputObject.BaseObject is Table)
				return (inputObject.BaseObject as Table).Code.Functions;
			if (inputObject.BaseObject is Page)
				return (inputObject.BaseObject as Page).Code.Functions;
			if (inputObject.BaseObject is Report)
				return (inputObject.BaseObject as Report).Code.Functions;
			if (inputObject.BaseObject is Codeunit)
				return (inputObject.BaseObject as Codeunit).Code.Functions;
			if (inputObject.BaseObject is Query)
				return (inputObject.BaseObject as Query).Code.Functions;
			if (inputObject.BaseObject is XmlPort)
				return (inputObject.BaseObject as XmlPort).Code.Functions;

			throw new ApplicationException("Cannot add functions to this type of object.");
		}

		protected override IEnumerable<Function> CreateItems()
		{
			var function = new Function(ID, Name);

			function.Local = Local;
#if NAV2016
			function.TryFunction = NullableBooleanFromSwitch(nameof(TryFunction));
#endif
			function.ReturnValue.Name = ReturnValueName;
			function.ReturnValue.Type = ReturnValueType;
			function.ReturnValue.DataLength = ReturnValueDataLength ?? function.ReturnValue.DefaultDataLength;
			function.ReturnValue.Dimensions = ReturnValueDimensions;

#if NAV2015 
			function.UpgradeFunctionType = UpgradeFunctionType;
#endif
			
			if (SubObjects != null)
			{
				var subObjects = SubObjects
					.Invoke()
					.Select(o => o.BaseObject);

				function.Variables.AddRange(subObjects.OfType<Variable>());
				function.Parameters.AddRange(subObjects.OfType<Parameter>());
				function.CodeLines.AddRange(subObjects.OfType<string>());
			}

			yield return function;
		}		
	}

#if NAV2016
	[Cmdlet(VerbsCommon.New, "CBreezeEventSubscriberFunction")]
	[OutputType(typeof(Function))]
	[Alias("EventSubscriber", "Add-CBreezeEventSubscriberFunction")]
	public class NewCBreezeEventSubscriberFunction : NewItemWithIDAndNameCmdlet<Function, int, PSObject>
	{
		[Parameter()] public SwitchParameter Local { get;set; }
		[Parameter()] public string ReturnValueName { get; set; } 
		[Parameter()] public FunctionReturnValueType? ReturnValueType { get; set; }
		[Parameter()] [ValidateRange(1, int.MaxValue)] public int? ReturnValueDataLength { get; set; }
		[Parameter()] public string ReturnValueDimensions { get; set; }

		[Parameter(Position = 2, ParameterSetName = ParameterSetNames.NewWithoutID)]
        [Parameter(Position = 3, ParameterSetName = ParameterSetNames.NewWithID)]
        [Parameter(Position = 2, ParameterSetName = ParameterSetNames.AddWithoutID)]
        [Parameter(Position = 3, ParameterSetName = ParameterSetNames.AddWithID)]
		public ScriptBlock SubObjects { get; set; }

#if NAV2016
		[Parameter()] public SwitchParameter TryFunction { get; set; }
#endif 
		[Parameter(Mandatory = true)] public ObjectType EventPublisherObjectType { get; set; } 
		[Parameter(Mandatory = true)] public int EventPublisherObjectID { get; set; } 
		[Parameter()] public string EventPublisherElement { get; set; } 
		[Parameter(Mandatory = true)] public string EventFunction { get; set; } 
		[Parameter()] public MissingAction? OnMissingLicense { get; set; } 
		[Parameter()] public MissingAction? OnMissingPermission { get; set; }

		protected override void AddItemToInputObject(Function item, PSObject inputObject)
		{
			GetFunctions(inputObject).Add(item);	
		}

		protected Functions GetFunctions(PSObject inputObject)
		{
			if (inputObject.BaseObject is Functions)
				return (inputObject.BaseObject as Functions);
			if (inputObject.BaseObject is Code)
				return (inputObject.BaseObject as Code).Functions;
			if (inputObject.BaseObject is Table)
				return (inputObject.BaseObject as Table).Code.Functions;
			if (inputObject.BaseObject is Page)
				return (inputObject.BaseObject as Page).Code.Functions;
			if (inputObject.BaseObject is Report)
				return (inputObject.BaseObject as Report).Code.Functions;
			if (inputObject.BaseObject is Codeunit)
				return (inputObject.BaseObject as Codeunit).Code.Functions;
			if (inputObject.BaseObject is Query)
				return (inputObject.BaseObject as Query).Code.Functions;
			if (inputObject.BaseObject is XmlPort)
				return (inputObject.BaseObject as XmlPort).Code.Functions;

			throw new ApplicationException("Cannot add functions to this type of object.");
		}

		protected override IEnumerable<Function> CreateItems()
		{
			var function = new Function(ID, Name);

			function.Local = Local;
#if NAV2016
			function.TryFunction = NullableBooleanFromSwitch(nameof(TryFunction));
#endif
			function.ReturnValue.Name = ReturnValueName;
			function.ReturnValue.Type = ReturnValueType;
			function.ReturnValue.DataLength = ReturnValueDataLength ?? function.ReturnValue.DefaultDataLength;
			function.ReturnValue.Dimensions = ReturnValueDimensions;

			function.Event = EventPublisherSubscriber.Subscriber;
			function.EventPublisherObject.Type = EventPublisherObjectType;
			function.EventPublisherObject.ID = EventPublisherObjectID;
			function.EventPublisherElement = EventPublisherElement;
			function.EventFunction = EventFunction;
			function.OnMissingLicense = OnMissingLicense;
			function.OnMissingPermission = OnMissingPermission;
			
			if (SubObjects != null)
			{
				var subObjects = SubObjects
					.Invoke()
					.Select(o => o.BaseObject);

				function.Variables.AddRange(subObjects.OfType<Variable>());
				function.Parameters.AddRange(subObjects.OfType<Parameter>());
				function.CodeLines.AddRange(subObjects.OfType<string>());
			}

			yield return function;
		}		
	}
#endif

#if NAV2016
	[Cmdlet(VerbsCommon.New, "CBreezeBusinessEventPublisherFunction")]
	[OutputType(typeof(Function))]
	[Alias("BusinessEvent", "Add-CBreezeBusinessEventPublisherFunction")]
	public class NewCBreezeBusinessEventPublisherFunction : NewItemWithIDAndNameCmdlet<Function, int, PSObject>
	{
		[Parameter()] public SwitchParameter Local { get;set; }
		[Parameter()] public string ReturnValueName { get; set; } 
		[Parameter()] public FunctionReturnValueType? ReturnValueType { get; set; }
		[Parameter()] [ValidateRange(1, int.MaxValue)] public int? ReturnValueDataLength { get; set; }
		[Parameter()] public string ReturnValueDimensions { get; set; }

		[Parameter(Position = 2, ParameterSetName = ParameterSetNames.NewWithoutID)]
        [Parameter(Position = 3, ParameterSetName = ParameterSetNames.NewWithID)]
        [Parameter(Position = 2, ParameterSetName = ParameterSetNames.AddWithoutID)]
        [Parameter(Position = 3, ParameterSetName = ParameterSetNames.AddWithID)]
		public ScriptBlock SubObjects { get; set; }

#if NAV2016
		[Parameter()] public SwitchParameter TryFunction { get; set; }
#endif 
		[Parameter()] public SwitchParameter IncludeSender { get; set; } 

		protected override void AddItemToInputObject(Function item, PSObject inputObject)
		{
			GetFunctions(inputObject).Add(item);	
		}

		protected Functions GetFunctions(PSObject inputObject)
		{
			if (inputObject.BaseObject is Functions)
				return (inputObject.BaseObject as Functions);
			if (inputObject.BaseObject is Code)
				return (inputObject.BaseObject as Code).Functions;
			if (inputObject.BaseObject is Table)
				return (inputObject.BaseObject as Table).Code.Functions;
			if (inputObject.BaseObject is Page)
				return (inputObject.BaseObject as Page).Code.Functions;
			if (inputObject.BaseObject is Report)
				return (inputObject.BaseObject as Report).Code.Functions;
			if (inputObject.BaseObject is Codeunit)
				return (inputObject.BaseObject as Codeunit).Code.Functions;
			if (inputObject.BaseObject is Query)
				return (inputObject.BaseObject as Query).Code.Functions;
			if (inputObject.BaseObject is XmlPort)
				return (inputObject.BaseObject as XmlPort).Code.Functions;

			throw new ApplicationException("Cannot add functions to this type of object.");
		}

		protected override IEnumerable<Function> CreateItems()
		{
			var function = new Function(ID, Name);

			function.Local = Local;
#if NAV2016
			function.TryFunction = NullableBooleanFromSwitch(nameof(TryFunction));
#endif
			function.ReturnValue.Name = ReturnValueName;
			function.ReturnValue.Type = ReturnValueType;
			function.ReturnValue.DataLength = ReturnValueDataLength ?? function.ReturnValue.DefaultDataLength;
			function.ReturnValue.Dimensions = ReturnValueDimensions;

			function.Event = EventPublisherSubscriber.Publisher;
			function.EventType = EventType.Business;
			function.IncludeSender = NullableBooleanFromSwitch(nameof(IncludeSender));
			
			if (SubObjects != null)
			{
				var subObjects = SubObjects
					.Invoke()
					.Select(o => o.BaseObject);

				function.Variables.AddRange(subObjects.OfType<Variable>());
				function.Parameters.AddRange(subObjects.OfType<Parameter>());
				function.CodeLines.AddRange(subObjects.OfType<string>());
			}

			yield return function;
		}		
	}
#endif

#if NAV2016
	[Cmdlet(VerbsCommon.New, "CBreezeIntegrationEventPublisherFunction")]
	[OutputType(typeof(Function))]
	[Alias("IntegrationEvent", "Add-CBreezeIntegrationEventPublisherFunction")]
	public class NewCBreezeIntegrationEventPublisherFunction : NewItemWithIDAndNameCmdlet<Function, int, PSObject>
	{
		[Parameter()] public SwitchParameter Local { get;set; }
		[Parameter()] public string ReturnValueName { get; set; } 
		[Parameter()] public FunctionReturnValueType? ReturnValueType { get; set; }
		[Parameter()] [ValidateRange(1, int.MaxValue)] public int? ReturnValueDataLength { get; set; }
		[Parameter()] public string ReturnValueDimensions { get; set; }

		[Parameter(Position = 2, ParameterSetName = ParameterSetNames.NewWithoutID)]
        [Parameter(Position = 3, ParameterSetName = ParameterSetNames.NewWithID)]
        [Parameter(Position = 2, ParameterSetName = ParameterSetNames.AddWithoutID)]
        [Parameter(Position = 3, ParameterSetName = ParameterSetNames.AddWithID)]
		public ScriptBlock SubObjects { get; set; }

#if NAV2016
		[Parameter()] public SwitchParameter TryFunction { get; set; }
#endif 
		[Parameter()] public SwitchParameter IncludeSender { get; set; }
		[Parameter()] public SwitchParameter GlobalVarAccess { get; set; } 

		protected override void AddItemToInputObject(Function item, PSObject inputObject)
		{
			GetFunctions(inputObject).Add(item);	
		}

		protected Functions GetFunctions(PSObject inputObject)
		{
			if (inputObject.BaseObject is Functions)
				return (inputObject.BaseObject as Functions);
			if (inputObject.BaseObject is Code)
				return (inputObject.BaseObject as Code).Functions;
			if (inputObject.BaseObject is Table)
				return (inputObject.BaseObject as Table).Code.Functions;
			if (inputObject.BaseObject is Page)
				return (inputObject.BaseObject as Page).Code.Functions;
			if (inputObject.BaseObject is Report)
				return (inputObject.BaseObject as Report).Code.Functions;
			if (inputObject.BaseObject is Codeunit)
				return (inputObject.BaseObject as Codeunit).Code.Functions;
			if (inputObject.BaseObject is Query)
				return (inputObject.BaseObject as Query).Code.Functions;
			if (inputObject.BaseObject is XmlPort)
				return (inputObject.BaseObject as XmlPort).Code.Functions;

			throw new ApplicationException("Cannot add functions to this type of object.");
		}

		protected override IEnumerable<Function> CreateItems()
		{
			var function = new Function(ID, Name);

			function.Local = Local;
#if NAV2016
			function.TryFunction = NullableBooleanFromSwitch(nameof(TryFunction));
#endif
			function.ReturnValue.Name = ReturnValueName;
			function.ReturnValue.Type = ReturnValueType;
			function.ReturnValue.DataLength = ReturnValueDataLength ?? function.ReturnValue.DefaultDataLength;
			function.ReturnValue.Dimensions = ReturnValueDimensions;

			function.Event = EventPublisherSubscriber.Publisher;
			function.EventType = EventType.Integration;
			function.IncludeSender = NullableBooleanFromSwitch(nameof(IncludeSender));
			function.GlobalVarAccess = NullableBooleanFromSwitch(nameof(GlobalVarAccess));

			
			if (SubObjects != null)
			{
				var subObjects = SubObjects
					.Invoke()
					.Select(o => o.BaseObject);

				function.Variables.AddRange(subObjects.OfType<Variable>());
				function.Parameters.AddRange(subObjects.OfType<Parameter>());
				function.CodeLines.AddRange(subObjects.OfType<string>());
			}

			yield return function;
		}		
	}
#endif

}