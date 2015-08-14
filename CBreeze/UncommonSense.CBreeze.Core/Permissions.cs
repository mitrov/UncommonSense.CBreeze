using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class Permissions : IEnumerable<Permission>
    {
        private Dictionary<Int32,Permission> innerList = new Dictionary<Int32,Permission>();

        internal Permissions()
        {
        }

        public Permission Add(Int32 tableID, Boolean readPermission, Boolean insertPermission, Boolean modifyPermission, Boolean deletePermission)
        {
            Permission item = new Permission(tableID, readPermission, insertPermission, modifyPermission, deletePermission);
            innerList.Add(tableID, item);
            return item;
        }

        public bool Remove(Int32 tableID)
        {
            return innerList.Remove(tableID);
        }

        public IEnumerator<Permission> GetEnumerator()
        {
            return innerList.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return innerList.Values.GetEnumerator();
        }
    }
}
