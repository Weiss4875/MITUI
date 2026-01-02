using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class MeshData : ShareDataObject
    {
        public struct VertexWeight
        {
            public Vector3 localPos;
            public Vector3 localNor;
            public Vector3 localTan;
            public int parentIndex;
            public float weight;
        }

        public bool isSkinning;
        public int vertexCount;
        public uint[] vertexInfoList;
        public VertexWeight[] vertexWeightList;
        public ulong[] vertexHashList;
        public Vector2[] uvList;
        public int lineCount;
        public int[] lineList;
        public int triangleCount;
        public int[] triangleList;
        public int boneCount;
        public uint[] vertexToTriangleInfoList;
        public int[] vertexToTriangleIndexList;
        public class ChildData : IDataHash
        {
            public int childDataHash;
            public int vertexCount;
            public uint[] vertexInfoList;
            public VertexWeight[] vertexWeightList;
            public int[] parentIndexList;
            public int VertexCount
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int GetDataHash()
            {
                throw new NotImplementedException();
            }
        }

        public List<ChildData> childDataList = new List<ChildData>();
        public Vector3 baseScale;
        public int VertexCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int VertexHashCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int WeightCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int LineCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int TriangleCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int BoneCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int ChildCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override int GetDataHash()
        {
            throw new NotImplementedException();
        }

        public override int GetVersion()
        {
            throw new NotImplementedException();
        }

        public override Define.Error VerifyData()
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, List<uint>> GetVirtualToChildVertexDict()
        {
            throw new NotImplementedException();
        }

        public List<int> ExtendSelection(List<int> originalSelection, bool extendNext, bool extendWeight)
        {
            throw new NotImplementedException();
        }
    }
}