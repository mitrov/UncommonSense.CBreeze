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
	public abstract partial class Variable : KeyedItem<int>, IHasName
	{
		internal Variable(int id, String name)
		{
			ID = id;
			Name = name;
		}

		public abstract VariableType Type
		{
			get;
		}

		public String Name
		{
			get;
			protected set;
		}

		public string GetName()
		{
			return Name;
		}
	}
}
