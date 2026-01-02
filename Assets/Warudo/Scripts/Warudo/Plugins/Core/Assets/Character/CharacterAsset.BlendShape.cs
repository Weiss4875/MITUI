using System;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using Newtonsoft.Json;
using UnityEngine;
using Warudo.Core.Utils;
using static Warudo.Plugins.Core.Assets.Character.CharacterAsset.ExpressionData.TriggerConditionEntry;
using System;
using Object = UnityEngine.Object;

namespace Warudo.Plugins.Core.Assets.Character
{
    public partial class CharacterAsset
    {
        public IEnumerable<string> ExpressionNames => throw new NotImplementedException();
        public IReadOnlyList<ExpressionLayer> ActiveExpressionLayers => throw new NotImplementedException();
        public HashSet<string> ActiveExpressions => throw new NotImplementedException();
        public IReadOnlyDictionary<string, Dictionary<string, float>> LastBlendShapes => throw new NotImplementedException();
        public IReadOnlyDictionary<string, Dictionary<string, object>> LastMaterialProperties => throw new NotImplementedException();
        public Dictionary<string, Dictionary<string, float>> TrackingBlendShapes = new(10);
        public Dictionary<string, Dictionary<string, float>> OverrideBlendShapes = new(10);
        public Dictionary<string, Dictionary<string, object>> TrackingMaterialProperties = new(10);
        public Dictionary<string, Dictionary<string, object>> OverrideMaterialProperties = new(10);
        public List<ExpressionLayer> ExpressionLayers = new();
        public void UpdateBlendShapes()
        {
            throw new NotImplementedException();
        }

        public void AddOverrideBlendShapeEntryProvider(IBlendShapeEntryProvider provider)
        {
            throw new NotImplementedException();
        }

        public void RemoveOverrideBlendShapeEntryProvider(IBlendShapeEntryProvider provider)
        {
            throw new NotImplementedException();
        }

        public void AddOverrideMaterialPropertyEntryProvider(IMaterialPropertyEntryProvider provider)
        {
            throw new NotImplementedException();
        }

        public void RemoveOverrideMaterialPropertyEntryProvider(IMaterialPropertyEntryProvider provider)
        {
            throw new NotImplementedException();
        }

        public bool HasExpression(string expressionName)
        {
            throw new NotImplementedException();
        }

        public void EnterExpression(string expressionName, bool transient)
        {
            throw new NotImplementedException();
        }

        public void ExitExpression(string expressionName)
        {
            throw new NotImplementedException();
        }

        public void ExitAllExpressions(bool fade = true)
        {
            throw new NotImplementedException();
        }

        public bool IsExpressionActive(string expressionName)
        {
            throw new NotImplementedException();
        }
    }
}