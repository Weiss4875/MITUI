using System;
using Object = UnityEngine.Object;

namespace MagicaReductionMesh
{
    public abstract class ReductionMeshAccess
    {
        protected ReductionMesh parent;
        protected MeshData MeshData
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        protected ReductionData ReductionData
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        protected DebugData DebugData
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual void SetParent(ReductionMesh parent)
        {
            throw new NotImplementedException();
        }
    }
}