using UnityEditor;
using UnityEditorInternal;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class CustomReorderableList : ReorderableList
    {
        public CustomReorderableList(SerializedObject serializedObject, SerializedProperty elements, string title) : base(serializedObject, elements, true, false, true, true)
        {
            throw new NotImplementedException();
        }
    }
}