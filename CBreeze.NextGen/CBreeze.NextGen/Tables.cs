﻿using System;

namespace CBreeze.NextGen
{
	public class Tables : Container<int, Table>
	{
		internal Tables(Node parentNode, params Table[] tables)
			: base(parentNode, tables)
		{
		}

		public override string ToString()
		{
			return "Tables";
		}
	}
}

