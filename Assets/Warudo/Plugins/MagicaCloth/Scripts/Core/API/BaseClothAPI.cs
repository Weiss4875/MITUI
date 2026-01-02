using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public abstract partial class BaseCloth : PhysicsTeam
    {
        public void ResetCloth()
        {
            throw new NotImplementedException();
        }

        public void ResetCloth(float resetStabilizationTime)
        {
            throw new NotImplementedException();
        }

        public void ResetCloth(ClothParams.TeleportMode teleportMode, float resetStabilizationTime = -1.0f)
        {
            throw new NotImplementedException();
        }

        public void SetTimeScale(float timeScale)
        {
            throw new NotImplementedException();
        }

        public float GetTimeScale()
        {
            throw new NotImplementedException();
        }

        public void AddForce(Vector3 force, PhysicsManagerTeamData.ForceMode mode)
        {
            throw new NotImplementedException();
        }

        public float BlendWeight
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void AddCollider(ColliderComponent collider)
        {
            throw new NotImplementedException();
        }

        public void RemoveCollider(ColliderComponent collider)
        {
            throw new NotImplementedException();
        }

        public void SetUpdateMode(TeamUpdateMode updateMode)
        {
            throw new NotImplementedException();
        }

        public void SetCullingMode(TeamCullingMode cullingMode)
        {
            throw new NotImplementedException();
        }

        public void Radius_SetRadius(float startVal, float endVal, float curveVal = 0)
        {
            throw new NotImplementedException();
        }

        public void Mass_SetMass(float startVal, float endVal, float curveVal = 0)
        {
            throw new NotImplementedException();
        }

        public void ClampPosition_SetPositionLength(float startVal, float endVal, float curveVal = 0)
        {
            throw new NotImplementedException();
        }

        public void Gravity_SetGravity(float startVal, float endVal, float curveVal = 0)
        {
            throw new NotImplementedException();
        }

        public Vector3 Gravity_GravityDirection
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Drag_SetDrag(float startVal, float endVal, float curveVal = 0)
        {
            throw new NotImplementedException();
        }

        public bool DistanceDisable_Active
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Transform DistanceDisable_ReferenceObject
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public float DistanceDisable_Distance
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public float DistanceDisable_FadeDistance
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void ExternalForce_DepthInfluence(float startVal, float endVal, float curveVal = 0)
        {
            throw new NotImplementedException();
        }

        public float ExternalForce_WindInfluence
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public float ExternalForce_WindRandomScale
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void WorldInfluence_SetMovementInfluence(float startVal, float endVal, float curveVal = 0)
        {
            throw new NotImplementedException();
        }

        public void WorldInfluence_SetRotationInfluence(float startVal, float endVal, float curveVal = 0)
        {
            throw new NotImplementedException();
        }

        public float WorldInfluence_MaxMoveSpeed
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool WorldInfluence_ResetAfterTeleport
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public float WorldInfluence_TeleportDistance
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public float WorldInfluence_TeleportRotation
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public ClothParams.TeleportMode WorldInfluence_TeleportMode
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public float WorldInfluence_StabilizationTime
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void WorldInfluence_ReplaceInfluenceTarget(Transform target)
        {
            throw new NotImplementedException();
        }

        public bool ColliderCollision_Active
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool Penetration_Active
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Penetration_SetMovingRadius(float startVal, float endVal, float curveVal = 0)
        {
            throw new NotImplementedException();
        }

        public bool Spring_Active
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public float Spring_Power
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}