using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    public enum TransactionType
    {
        UpdateNoLocks,
        Update,
        Snapshot,
        Browse,
        Report,
    }

}
