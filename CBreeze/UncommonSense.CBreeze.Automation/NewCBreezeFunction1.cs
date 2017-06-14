﻿using System;
using System.Linq;
using System.Management.Automation;
using System.Collections.Generic;
using UncommonSense.CBreeze.Common;
using UncommonSense.CBreeze.Core;

namespace UncommonSense.CBreeze.Automation 
{
	[Cmdlet(VerbsCommon.New, "CBreezeFunction")]
	[OutputType(typeof(Function))]
	[Alias("Procedure")]
	public class NewCBreezeFunction : NewItemWithIDAndNameCmdlet<Function, int, PSObject>
	{
		[Parameter()] public bool? Local { get;set; }
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
		[Parameter()] public bool? TryFunction { get; set; }
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
			function.TryFunction = TryFunction;
#endif
			function.ReturnValue.Name = ReturnValueName;
			function.ReturnValue.Type = ReturnValueType;
			function.ReturnValue.DataLength = GetReturnValueDataLength();
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

		protected int? GetReturnValueDataLength()
		{
			if (!ReturnValueType.HasValue) return null;
			if (ReturnValueDataLength.HasValue) return ReturnValueDataLength;

			switch (ReturnValueType.Value)
			{
				case FunctionReturnValueType.Text: return 30;
				case FunctionReturnValueType.Code: return 10;
				default: return null;
			}	
		}
	}

	[Cmdlet(VerbsCommon.New, "CBreezeTestFunction")]
	[OutputType(typeof(Function))]
	[Alias("TestFunction")]
	public class NewCBreezeTestFunction : NewItemWithIDAndNameCmdlet<Function, int, PSObject>
	{
		[Parameter()] public bool? Local { get;set; }
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
		[Parameter()] public bool? TryFunction { get; set; }
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
			function.TryFunction = TryFunction;
#endif
			function.ReturnValue.Name = ReturnValueName;
			function.ReturnValue.Type = ReturnValueType;
			function.ReturnValue.DataLength = GetReturnValueDataLength();
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

		protected int? GetReturnValueDataLength()
		{
			if (!ReturnValueType.HasValue) return null;
			if (ReturnValueDataLength.HasValue) return ReturnValueDataLength;

			switch (ReturnValueType.Value)
			{
				case FunctionReturnValueType.Text: return 30;
				case FunctionReturnValueType.Code: return 10;
				default: return null;
			}	
		}
	}

	[Cmdlet(VerbsCommon.New, "CBreezeUpgradeFunction")]
	[OutputType(typeof(Function))]
	[Alias("UpgradeFunction")]
	public class NewCBreezeUpgradeFunction : NewItemWithIDAndNameCmdlet<Function, int, PSObject>
	{
		[Parameter()] public bool? Local { get;set; }
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
		[Parameter()] public bool? TryFunction { get; set; }
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
			function.TryFunction = TryFunction;
#endif
			function.ReturnValue.Name = ReturnValueName;
			function.ReturnValue.Type = ReturnValueType;
			function.ReturnValue.DataLength = GetReturnValueDataLength();
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

		protected int? GetReturnValueDataLength()
		{
			if (!ReturnValueType.HasValue) return null;
			if (ReturnValueDataLength.HasValue) return ReturnValueDataLength;

			switch (ReturnValueType.Value)
			{
				case FunctionReturnValueType.Text: return 30;
				case FunctionReturnValueType.Code: return 10;
				default: return null;
			}	
		}
	}

#if NAV2016
	[Cmdlet(VerbsCommon.New, "CBreezeEventSubscriberFunction")]
	[OutputType(typeof(Function))]
	[Alias("EventSubscriber")]
	public class NewCBreezeEventSubscriberFunction : NewItemWithIDAndNameCmdlet<Function, int, PSObject>
	{
		[Parameter()] public bool? Local { get;set; }
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
		[Parameter()] public bool? TryFunction { get; set; }
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
			function.TryFunction = TryFunction;
#endif
			function.ReturnValue.Name = ReturnValueName;
			function.ReturnValue.Type = ReturnValueType;
			function.ReturnValue.DataLength = GetReturnValueDataLength();
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

		protected int? GetReturnValueDataLength()
		{
			if (!ReturnValueType.HasValue) return null;
			if (ReturnValueDataLength.HasValue) return ReturnValueDataLength;

			switch (ReturnValueType.Value)
			{
				case FunctionReturnValueType.Text: return 30;
				case FunctionReturnValueType.Code: return 10;
				default: return null;
			}	
		}
	}
#endif

#if NAV2016
	[Cmdlet(VerbsCommon.New, "CBreezeBusinessEventPublisherFunction")]
	[OutputType(typeof(Function))]
	[Alias("BusinessEvent")]
	public class NewCBreezeBusinessEventPublisherFunction : NewItemWithIDAndNameCmdlet<Function, int, PSObject>
	{
		[Parameter()] public bool? Local { get;set; }
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
		[Parameter()] public bool? TryFunction { get; set; }
#endif 
		[Parameter()] public bool? IncludeSender { get; set; } 

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
			function.TryFunction = TryFunction;
#endif
			function.ReturnValue.Name = ReturnValueName;
			function.ReturnValue.Type = ReturnValueType;
			function.ReturnValue.DataLength = GetReturnValueDataLength();
			function.ReturnValue.Dimensions = ReturnValueDimensions;

			function.Event = EventPublisherSubscriber.Publisher;
			function.EventType = EventType.Business;
			function.IncludeSender = IncludeSender;
			
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

		protected int? GetReturnValueDataLength()
		{
			if (!ReturnValueType.HasValue) return null;
			if (ReturnValueDataLength.HasValue) return ReturnValueDataLength;

			switch (ReturnValueType.Value)
			{
				case FunctionReturnValueType.Text: return 30;
				case FunctionReturnValueType.Code: return 10;
				default: return null;
			}	
		}
	}
#endif

#if NAV2016
	[Cmdlet(VerbsCommon.New, "CBreezeIntegrationEventPublisherFunction")]
	[OutputType(typeof(Function))]
	[Alias("IntegrationEvent")]
	public class NewCBreezeIntegrationEventPublisherFunction : NewItemWithIDAndNameCmdlet<Function, int, PSObject>
	{
		[Parameter()] public bool? Local { get;set; }
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
		[Parameter()] public bool? TryFunction { get; set; }
#endif 
		[Parameter()] public bool? IncludeSender { get; set; }
		[Parameter()] public bool? GlobalVarAccess { get; set; } 

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
			function.TryFunction = TryFunction;
#endif
			function.ReturnValue.Name = ReturnValueName;
			function.ReturnValue.Type = ReturnValueType;
			function.ReturnValue.DataLength = GetReturnValueDataLength();
			function.ReturnValue.Dimensions = ReturnValueDimensions;

			function.Event = EventPublisherSubscriber.Publisher;
			function.EventType = EventType.Integration;
			function.IncludeSender = IncludeSender;
			function.GlobalVarAccess = GlobalVarAccess;

			
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

		protected int? GetReturnValueDataLength()
		{
			if (!ReturnValueType.HasValue) return null;
			if (ReturnValueDataLength.HasValue) return ReturnValueDataLength;

			switch (ReturnValueType.Value)
			{
				case FunctionReturnValueType.Text: return 30;
				case FunctionReturnValueType.Code: return 10;
				default: return null;
			}	
		}
	}
#endif

}