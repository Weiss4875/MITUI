using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class SimpleInputManager : CreateSingleton<SimpleInputManager>
    {
        public float tapRadiusCm = 0.5f;
        public float flickRangeCm = 0.01f;
        public float flickCheckSpeed = 1.0f;
        public float mouseWheelSpeed = 5.0f;
        public static UnityAction<int, Vector2> OnTouchDown;
        public static UnityAction<int, Vector2, Vector2, Vector2> OnTouchMove;
        public static UnityAction<int, Vector2, Vector2, Vector2> OnDoubleTouchMove;
        public static UnityAction<int, Vector2> OnTouchUp;
        public static UnityAction<int, Vector2> OnTouchMoveCancel;
        public static UnityAction<int, Vector2> OnTouchTap;
        public static UnityAction<int, Vector2, Vector2, Vector2> OnTouchFlick;
        public static UnityAction<float, float> OnTouchPinch;
        public static UnityAction OnBackButton;
        protected override void InitSingleton()
        {
            throw new NotImplementedException();
        }

        void Update()
        {
            throw new NotImplementedException();
        }

        public static float ScreenDpi
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public static float ScreenDpc
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int GetTouchCount()
        {
            throw new NotImplementedException();
        }

        public bool IsUI()
        {
            throw new NotImplementedException();
        }
    }
}