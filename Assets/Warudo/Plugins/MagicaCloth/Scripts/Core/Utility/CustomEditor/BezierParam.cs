using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class BezierParam : IDataHash
    {
        public BezierParam()
        {
            throw new NotImplementedException();
        }

        public BezierParam(float val)
        {
            throw new NotImplementedException();
        }

        public BezierParam(float sval, float eval)
        {
            throw new NotImplementedException();
        }

        public BezierParam(float sval, float eval, bool useEval, float cval, bool useCval)
        {
            throw new NotImplementedException();
        }

        public void SetParam(float sval, float eval, bool useEval = true, float cval = 0.0f, bool useCval = false)
        {
            throw new NotImplementedException();
        }

        public float StartValue
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float EndValue
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float CurveValue
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool UseCurve
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float Evaluate(float x)
        {
            throw new NotImplementedException();
        }

        public BezierParam AutoSetup(float startVal, float endVal, float curveVal = 0)
        {
            throw new NotImplementedException();
        }

        public int GetDataHash()
        {
            throw new NotImplementedException();
        }

        public BezierParam Clone()
        {
            throw new NotImplementedException();
        }
    }
}