using Unity.Jobs;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public abstract class PhysicsManagerConstraint
    {
        public int iteration = 1;
        public MagicaPhysicsManager Manager { get; set; }

        public void Init(MagicaPhysicsManager manager)
        {
            throw new NotImplementedException();
        }

        public abstract void Create();
        public abstract void RemoveTeam(int teamId);
        public abstract void Release();
        public virtual int GetIterationCount()
        {
            throw new NotImplementedException();
        }

        public abstract JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle);
    }
}