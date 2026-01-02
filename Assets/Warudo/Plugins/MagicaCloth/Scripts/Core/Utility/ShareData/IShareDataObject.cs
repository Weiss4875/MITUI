using System.Collections.Generic;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public interface IShareDataObject
    {
        List<ShareDataObject> GetAllShareDataObject();
        ShareDataObject DuplicateShareDataObject(ShareDataObject source);
    }
}