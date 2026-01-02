using System;
using System.Collections.Generic;
using UnityEngine;
using Warudo.Core.Utils;
using Warudo.Plugins.Core.Assets.Character;
using Warudo.Plugins.Core.Utils;
using System;
using Object = UnityEngine.Object;

namespace Warudo.Plugins.Core.Assets
{
    public class MeshUpdater
    {
        public MeshUpdater(Func<IReadOnlyDictionary<string, MeshRenderer>> meshRenderersGetter, Func<IReadOnlyDictionary<string, SkinnedMeshRenderer>> skinnedMeshRenderersGetter, Func<IReadOnlyDictionary<string, List<Material>>> materialsGetter, Func<IReadOnlyDictionary<string, CharacterAsset.VRMBlendShapeClipData>> vrmBlendShapeClipsGetter)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public object GetInitialMaterialPropertyValue(string materialName, string propertyName, MaterialPropertyType propertyType)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlendShapes(IReadOnlyDictionary<string, SkinnedMeshRenderer> skinnedMeshRenderers, IReadOnlyDictionary<string, Dictionary<string, float>> blendShapes)
        {
            throw new NotImplementedException();
        }

        public void ApplyBlendShapeEntry(IReadOnlyDictionary<string, SkinnedMeshRenderer> skinnedMeshRenderers, IReadOnlyDictionary<string, CharacterAsset.VRMBlendShapeClipData> vrmBlendShapeClips, IBlendShapeEntry bs)
        {
            throw new NotImplementedException();
        }

        public void UpdateMaterialProperties(IReadOnlyDictionary<string, Dictionary<string, object>> materialProperties)
        {
            throw new NotImplementedException();
        }

        public void ApplyMaterialPropertyEntry(IReadOnlyDictionary<string, CharacterAsset.VRMBlendShapeClipData> vrmBlendShapeClips, IMaterialPropertyEntry mp)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<IBlendShapeEntry> defaultBlendShapes, IEnumerable<IMaterialPropertyEntry> defaultMaterialProperties, IReadOnlyDictionary<string, Dictionary<string, float>> blendShapes, IReadOnlyDictionary<string, Dictionary<string, object>> materialProperties, IEnumerable<IBlendShapeEntryProvider> overrideBlendShapeEntryProviders = null, IEnumerable<IMaterialPropertyEntryProvider> overrideMaterialPropertyEntryProviders = null)
        {
            throw new NotImplementedException();
        }

        public void ResetBlendShapes(string smrName)
        {
            throw new NotImplementedException();
        }

        public void ResetBlendShapes()
        {
            throw new NotImplementedException();
        }

        public void ResetBlendShapesNextFrame()
        {
            throw new NotImplementedException();
        }

        public void ResetMaterialProperties(string materialName)
        {
            throw new NotImplementedException();
        }

        public void ResetMaterialProperties()
        {
            throw new NotImplementedException();
        }

        public void ResetMaterialPropertiesNextFrame()
        {
            throw new NotImplementedException();
        }

        public static Dictionary<string, List<Material>> GetMaterials(IEnumerable<Renderer> renderers)
        {
            throw new NotImplementedException();
        }
    }
}