﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UncommonSense.CBreeze.Common;

namespace UncommonSense.CBreeze.Parse
{
    public partial class Parser
    {
        internal void ParseQueryElement(Lines lines)
        {
            var match = lines.FirstLineMustMatch(Patterns.QueryElement);
            var elementID = match.Groups[1].Value.ToInteger();
            var elementIndentation = match.Groups[2].Value.ToNullableInteger();
            var elementType = match.Groups[3].Value.ToEnum<QueryElementType>();
            var elementName = match.Groups[4].Value.Trim();
            var propertyIndentation = (lines.First().Length - lines.First().TrimStart().Length);

            Listener.OnBeginQueryElement(elementID, elementIndentation, elementName,elementType);

            lines.Unindent(propertyIndentation);
            lines.LastLineMustMatch(Patterns.BlankLine);
            lines.LastLineMustMatch(Patterns.EndQueryElement);

            foreach (var chunk in lines.Chunks(Patterns.PropertySignature))
            {
                ParseProperty(chunk, true);
            }

            Listener.OnEndQueryElement();
        }
    }
}
