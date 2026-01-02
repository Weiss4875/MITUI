using Unity.Mathematics;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public struct CurveParam
    {
        public float sval;
        public float eval;
        public float cval;
        public int useCurve;
        public CurveParam(float value)
        {
            throw new NotImplementedException();
        }

        public CurveParam(float svalue, float evalue)
        {
            throw new NotImplementedException();
        }

        public CurveParam(BezierParam bezier)
        {
            throw new NotImplementedException();
        }

        public void Setup(BezierParam bezier)
        {
            throw new NotImplementedException();
        }

        public float Evaluate(float t)
        {
            throw new NotImplementedException();
        }
    }
}