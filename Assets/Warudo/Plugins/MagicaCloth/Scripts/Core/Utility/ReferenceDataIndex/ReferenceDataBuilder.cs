using System.Collections.Generic;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class ReferenceDataBuilder<T>
        where T : struct
    {
        public void Init(int indexCount)
        {
            throw new NotImplementedException();
        }

        public void AddData(T data, params int[] indexes)
        {
            throw new NotImplementedException();
        }

        public (List<ReferenceDataIndex>, List<T>) GetDirectReferenceData()
        {
            throw new NotImplementedException();
        }

        public (List<ReferenceDataIndex>, List<int>, List<List<int>>) GetIndirectReferenceData()
        {
            throw new NotImplementedException();
        }
    }
}