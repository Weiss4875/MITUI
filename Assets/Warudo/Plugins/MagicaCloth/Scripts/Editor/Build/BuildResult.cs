using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class BuildResult
    {
        public int SuccessCount => throw new NotImplementedException();
        public int FailedCount => throw new NotImplementedException();
        public Define.Error LastError => throw new NotImplementedException();
        public BuildResult()
        {
            throw new NotImplementedException();
        }

        public BuildResult(Define.Error err)
        {
            throw new NotImplementedException();
        }

        public void Merge(BuildResult src)
        {
            throw new NotImplementedException();
        }

        public void SetError(Define.Error err)
        {
            throw new NotImplementedException();
        }

        public void SetSuccess()
        {
            throw new NotImplementedException();
        }

        public string GetErrorMessage()
        {
            throw new NotImplementedException();
        }

        public bool IsSuccess()
        {
            throw new NotImplementedException();
        }

        public bool IsError()
        {
            throw new NotImplementedException();
        }
    }
}