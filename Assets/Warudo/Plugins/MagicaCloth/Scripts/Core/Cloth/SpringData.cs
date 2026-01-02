using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class SpringData : ShareDataObject
    {
        public class DeformerData : IDataHash
        {
            public int deformerDataHash;
            public int vertexCount;
            public int[] useVertexIndexList;
            public float[] weightList;
            public int UseVertexCount
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

        public DeformerData deformerData;
        public Vector3 initScale;
        public override int GetDataHash()
        {
            throw new NotImplementedException();
        }

        public int UseVertexCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override int GetVersion()
        {
            throw new NotImplementedException();
        }

        public override Define.Error VerifyData()
        {
            throw new NotImplementedException();
        }
    }
}