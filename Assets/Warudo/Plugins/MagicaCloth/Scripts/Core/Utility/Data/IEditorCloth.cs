using System.Collections.Generic;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public interface IEditorCloth
    {
        List<int> GetSelectionList();
        List<int> GetUseList();
    }
}