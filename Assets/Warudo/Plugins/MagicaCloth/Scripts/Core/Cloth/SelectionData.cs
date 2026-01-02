using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class SelectionData : ShareDataObject
    {
        public const int Invalid = 0;
        public const int Move = 1;
        public const int Fixed = 2;
        public const int Extend = 3;
        public class DeformerSelection : IDataHash
        {
            public List<int> selectData = new List<int>();
            public List<ulong> vertexHashList = new List<ulong>();
            public int GetDataHash()
            {
                throw new NotImplementedException();
            }

            public bool Compare(DeformerSelection data)
            {
                throw new NotImplementedException();
            }
        }

        public List<DeformerSelection> selectionList = new List<DeformerSelection>();
        public int DeformerCount
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

        public bool Compare(SelectionData sel)
        {
            throw new NotImplementedException();
        }

        public List<int> GetSelectionData(MeshData meshData, List<MeshData> childMeshDataList)
        {
            throw new NotImplementedException();
        }

        public void SetSelectionData(MeshData meshData, List<int> selects, List<MeshData> childMeshDataList)
        {
            throw new NotImplementedException();
        }
    }
}