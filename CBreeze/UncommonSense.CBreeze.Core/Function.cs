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
    public partial class Function : KeyedItem<int>, IHasName, IHasParameters
    {
        private Variables variables = new Variables();

        public Function(int id, String name)
        {
            ID = id;
            Name = name;
            CodeLines = new CodeLines();
            Parameters = new Parameters();
            Properties = new FunctionProperties();
            ReturnValue = new FunctionReturnValue();
            Variables = new Variables();
        }

        public String Name
        {
            get;
            protected set;
        }

        public CodeLines CodeLines
        {
            get;
            protected set;
        }

        public Parameters Parameters
        {
            get;
            protected set;
        }

        public FunctionProperties Properties
        {
            get;
            protected set;
        }

        public FunctionReturnValue ReturnValue
        {
            get;
            protected set;
        }

        public Variables Variables
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
