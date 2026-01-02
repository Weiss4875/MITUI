using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class ClothSetup
    {
        int teamBoneIndex = -1;
        float distanceBlendRatio = 1.0f;
        public void ClothInit(PhysicsTeam team, MeshData meshData, ClothData clothData, ClothParams param, System.Func<int, uint> funcUserFlag)
        {
            throw new NotImplementedException();
        }

        public void ClothDispose(PhysicsTeam team)
        {
            throw new NotImplementedException();
        }

        public void ClothActive(PhysicsTeam team, ClothParams param, ClothData clothData)
        {
            throw new NotImplementedException();
        }

        public void ClothInactive(PhysicsTeam team)
        {
            throw new NotImplementedException();
        }

        internal void ReplaceBone<T>(PhysicsTeam team, ClothParams param, Dictionary<T, Transform> boneReplaceDict)
            where T : class
        {
            throw new NotImplementedException();
        }

        internal HashSet<Transform> GetUsedBones(PhysicsTeam team, ClothParams param)
        {
            throw new NotImplementedException();
        }

        public void ChangeUseUnityPhysics(bool sw)
        {
            throw new NotImplementedException();
        }

        public float DistanceBlendRatio
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void ChangeData(PhysicsTeam team, ClothParams param, ClothData clothData)
        {
            throw new NotImplementedException();
        }
    }
}