using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public abstract class ClothEditor : Editor
    {
        PointSelector pointSelector = new PointSelector();
        List<int> selectorData = new List<int>();
        IEditorMesh editorMesh;
        protected virtual void OnEnable()
        {
            throw new NotImplementedException();
        }

        protected virtual void OnDisable()
        {
            throw new NotImplementedException();
        }

        protected virtual void OnResetSelector(List<int> selectorData)
        {
            throw new NotImplementedException();
        }

        protected virtual void OnFinishSelector(List<int> selectorData)
        {
            throw new NotImplementedException();
        }

        protected void DrawInspectorGUI(IEditorMesh editorMesh)
        {
            throw new NotImplementedException();
        }

        protected void InitSelectorData()
        {
            throw new NotImplementedException();
        }

        protected abstract bool CheckCreate();
        void StartEdit(PointSelector pointSelector)
        {
            throw new NotImplementedException();
        }

        void EndEdit(PointSelector pointSelector)
        {
            throw new NotImplementedException();
        }

        protected SelectionData CreateSelection(MonoBehaviour obj, string property)
        {
            throw new NotImplementedException();
        }

        protected void ApplySelection(MonoBehaviour obj, string property, SelectionData selectionData)
        {
            throw new NotImplementedException();
        }

        protected void TeamBasicInspector()
        {
            throw new NotImplementedException();
        }

        protected void CullingInspector()
        {
            throw new NotImplementedException();
        }

        protected void ColliderInspector()
        {
            throw new NotImplementedException();
        }

        protected void SkinningInspector()
        {
            throw new NotImplementedException();
        }

        protected void ConvertToLatestAlgorithmParameters()
        {
            throw new NotImplementedException();
        }
    }
}