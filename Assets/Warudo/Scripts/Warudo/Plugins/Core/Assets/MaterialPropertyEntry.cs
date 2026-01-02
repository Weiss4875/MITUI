using System;
using System.Collections.Generic;
using System.Linq;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using Warudo.Core.Attributes;
using Warudo.Core.Data;
using Warudo.Core.Localization;
using Warudo.Plugins.Core.Assets.Character;
using System;
using Object = UnityEngine.Object;

namespace Warudo.Plugins.Core.Assets
{
    public enum MaterialPropertyType
    {
        Color,
        Vector,
        Float,
        Int
    }

    public interface IMaterialPropertyEntry
    {
        bool GetUseVRMBlendShapeProxy();
        string GetVRMBlendShapeClip();
        string GetMaterial();
        string GetProperty();
        MaterialPropertyType GetPropertyType();
        object GetValue();
    }

    public class MaterialPropertyEntry : IMaterialPropertyEntry
    {
        public bool UseVRMBlendShapeProxy;
        public string VRMBlendShapeClip;
        public string Material;
        public string Property;
        public MaterialPropertyType PropertyType;
        public object Value;
        public bool GetUseVRMBlendShapeProxy() => throw new NotImplementedException();
        public string GetVRMBlendShapeClip() => throw new NotImplementedException();
        public string GetMaterial() => throw new NotImplementedException();
        public string GetProperty() => throw new NotImplementedException();
        public MaterialPropertyType GetPropertyType() => throw new NotImplementedException();
        public object GetValue() => throw new NotImplementedException();
    }

    public interface IMaterialPropertyEntryProvider
    {
        IEnumerable<IMaterialPropertyEntry> ProvideMaterialPropertyEntries();
    }

    public abstract class MaterialPropertyEntryBase<TParent> : StructuredData<TParent>, IMaterialPropertyEntry, ICollapsibleStructuredData where TParent : Entity
    {
        protected abstract bool ParentActive { get; }

        protected abstract IEnumerable<string> ParentMaterialNames { get; }

        protected abstract CharacterAsset ParentCharacter { get; }

        protected bool HideVRMBlendShapeProxyDataInputs() => throw new NotImplementedException();
        protected virtual bool HideTransitionDataInputs() => throw new NotImplementedException();
        protected virtual bool DisableFadeDataInputs() => throw new NotImplementedException();
        public bool UseVRMBlendShapeProxy = false;
        public string BlendShape;
        protected async UniTask<AutoCompleteList> AutoCompleteBlendShapes()
        {
            throw new NotImplementedException();
        }

        public float TargetValue = 1f;
        public string Material;
        public MaterialPropertyType PropertyType;
        public string Property;
        public Color TargetColorValue;
        protected bool HideTargetColorValue() => throw new NotImplementedException();
        public Vector4 TargetVectorValue;
        protected bool HideTargetVectorValue() => throw new NotImplementedException();
        public float TargetFloatValue;
        protected bool HideTargetFloatValue() => throw new NotImplementedException();
        public int TargetIntValue;
        protected bool HideTargetIntValue() => throw new NotImplementedException();
        public float EnterDuration = 0.4f;
        public Ease EnterEase = Ease.OutCubic;
        public float EnterDelay = 0f;
        public float ExitDuration = 0.4f;
        public Ease ExitEase = Ease.Linear;
        public float ExitDelay = 0f;
        public virtual bool GetUseVRMBlendShapeProxy() => throw new NotImplementedException();
        public virtual string GetVRMBlendShapeClip() => throw new NotImplementedException();
        public virtual string GetMaterial() => throw new NotImplementedException();
        public virtual string GetProperty() => throw new NotImplementedException();
        public virtual MaterialPropertyType GetPropertyType() => throw new NotImplementedException();
        public virtual object GetValue() => throw new NotImplementedException();
        protected async UniTask<AutoCompleteList> AutoCompleteMaterial()
        {
            throw new NotImplementedException();
        }

        public virtual string GetHeader()
        {
            throw new NotImplementedException();
        }
    }
}