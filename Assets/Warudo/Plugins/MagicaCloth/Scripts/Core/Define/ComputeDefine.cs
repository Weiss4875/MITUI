using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public static partial class Define
    {
        public static class Compute
        {
            public const float Epsilon = 1e-6f;
            public const float CollisionFrictionRange = 0.03f;
            public const float FrictionDampingRate = 0.6f;
            public const float FrictionMoveRatio = 0.5f;
            public const float FrictionPower = 4.0f;
            public const float ClampPositionMaxVelocity = 1.0f;
            public const float GlobalColliderMaxMoveDistance = 0.2f;
            public const float GlobalColliderMaxRotationAngle = 10.0f;
            public const float ColliderExtrusionMaxPower = 0.4f;
            public const float ColliderExtrusionDirectionPower = 0.3f;
            public const float ColliderExtrusionDistPower = 2.0f;
            public const float ColliderExtrusionVelocityInfluence = 0.25f;
            public const float MaxWindMain = 100;
            public const float ClampRotationMaxVelocity = 1.0f;
            public const float ClampRotationMaxVelocity2 = 2.0f;
            public const float TriangleBendVelocityInfluence = 0.5f;
        }
    }
}