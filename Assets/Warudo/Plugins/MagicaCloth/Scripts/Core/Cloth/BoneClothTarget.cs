using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class BoneClothTarget : IDataHash, IBoneReplace
    {
        public enum ConnectionMode
        {
            Line = 0,
            MeshAutomatic = 1,
            MeshSequentialLoop = 2,
            MeshSequentialNoLoop = 3,
        }

        public int GetDataHash()
        {
            throw new NotImplementedException();
        }

        public int RootCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Transform GetRoot(int index)
        {
            throw new NotImplementedException();
        }

        public int GetRootIndex(Transform root)
        {
            throw new NotImplementedException();
        }

        public void AddParentTransform()
        {
            throw new NotImplementedException();
        }

        public void RemoveParentTransform()
        {
            throw new NotImplementedException();
        }

        public void ResetFuturePredictionParentTransform()
        {
            throw new NotImplementedException();
        }

        public void ChangeUnityPhysicsCount(bool sw)
        {
            throw new NotImplementedException();
        }

        public ConnectionMode Connection
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float SameSurfaceAngle
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsMeshConnection
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict)
            where T : class
        {
            throw new NotImplementedException();
        }

        public HashSet<Transform> GetUsedBones()
        {
            throw new NotImplementedException();
        }
    }
}