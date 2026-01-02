using System;
using UnityEngine;
using Warudo.Plugins.Core.Utils;
using System;
using Object = UnityEngine.Object;

namespace Warudo.Plugins.Core.Assets.Cinematography
{
    public class FreeCamera
    {
        public float UserSensitivity = 1f;
        public float Sensitivity => throw new NotImplementedException();
        public Action OnTransformUpdated;
        float inputRotateAxisX, inputRotateAxisY;
        float inputPanAxisX, inputPanAxisY;
        float inputVertical, inputHorizontal, inputZoom, inputYAxis;
        bool leftShift;
        void UpdateInputs(bool controllerInput)
        {
            throw new NotImplementedException();
        }

        public void OnUpdate(Transform transform, bool controllerInput)
        {
            throw new NotImplementedException();
        }
    }
}