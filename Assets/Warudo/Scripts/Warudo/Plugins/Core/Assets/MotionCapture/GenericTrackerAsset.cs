using System.Collections.Generic;
using RootMotion;
using RootMotion.FinalIK;
using UnityEngine;
using Warudo.Core;
using Warudo.Core.Attributes;
using Warudo.Core.Data;
using Warudo.Core.Data.Models;
using Warudo.Core.Localization;
using Warudo.Core.Server;
using Warudo.Core.Utils;
using Warudo.Plugins.Core.Assets.Character;
using System;
using Object = UnityEngine.Object;

namespace Warudo.Plugins.Core.Assets.MotionCapture
{
    public abstract class GenericTrackerAsset : CharacterDaemonAsset
    {
        protected abstract bool UseCharacterDaemon { get; }

        protected abstract bool UseHeadIK { get; }

        protected virtual bool UseCharacterDaemonBones => throw new NotImplementedException();
        protected virtual bool ProvideHeadTracking => throw new NotImplementedException();
        protected virtual bool CanCalibrate => throw new NotImplementedException();
        protected virtual bool IsInputHeadTransformMirrored => throw new NotImplementedException();
        protected virtual Vector2 EyeMovementIntensityBaseMultiplier => throw new NotImplementedException();
        protected virtual bool UseEyeInputs => throw new NotImplementedException();
        public virtual List<string> InputBlendShapes => throw new NotImplementedException();
        protected bool HideHeadTranslationProperties() => throw new NotImplementedException();
        protected bool HideHeadRotationProperties() => throw new NotImplementedException();
        protected bool HideCalibrate() => throw new NotImplementedException();
        protected override bool HideCharacterDataInput() => throw new NotImplementedException();
        protected bool IsStarted { get; set; }

        public bool MirroredTracking = false;
        public bool CalibrateEyeMovement = true;
        protected void TriggerCalibrate()
        {
            throw new NotImplementedException();
        }

        public BlendShapesMappingData BlendShapesMapping;
        protected async void ConfigureBlendShapeMapping()
        {
            throw new NotImplementedException();
        }

        protected bool HideConfigureBlendShapeMapping() => throw new NotImplementedException();
        public float BlendShapeSensitivity = 1f;
        public Vector3 HeadMovementIntensity = new Vector3(2f, 2f, 2f);
        public Vector3 MaximalHeadTranslation = new Vector3(0.5f, 0.5f, 0.5f);
        public float BodyMovementIntensity = 0.5f;
        public Vector3 HeadRotationIntensity = Vector3.one;
        public Vector3 MaximalHeadRotation = new Vector3(60f, 60f, 60f);
        public Vector3 HeadRotationOffset = Vector3.zero;
        public Vector2 EyeMovementIntensity = new Vector3(1f, 1f);
        public Vector2 EyeMovementHeadRotationCompensation = Vector2.zero;
        public float EyeBlinkSensitivity = 1.2f;
        public bool LinkedEyeBlinking = false;
        public bool LimitEyeSquint = false;
        public bool UseBonesForEyeMovement = true;
        public bool AverageEyeRotations = false;
        protected bool HideAverageEyeRotations() => throw new NotImplementedException();
        public bool UseBlendShapesForEyeMovement = false;
        public bool ConvertToVRMEyeBlendShapes = false;
        protected bool HideConvertToVRMEyeBlendShapes() => throw new NotImplementedException();
        protected bool DisableCalibrate() => throw new NotImplementedException();
        protected bool HideEyeInputs() => throw new NotImplementedException();
        public bool IsTracked { get; private set; }

        public Dictionary<string, float> LatestBlendShapes { get; }

        public Vector3 LatestHeadPosition { get; private set; }

        public Quaternion[] LatestBoneRotations { get; }

        public Vector3 LatestRootPosition { get; private set; }

        public Vector3[] LatestBonePositions { get; }

        public TransformData LatestRootTransform { get; }

        protected Dictionary<string, float> RawBlendShapes { get; }

        protected Vector3 RawHeadPosition { get; set; }

        protected Quaternion[] RawBoneRotations { get; set; }

        protected Vector3[] RawBonePositions { get; set; }

        protected Vector3 RawRootPosition { get; set; }

        protected TransformData RawRootTransform { get; set; }

        protected Vector3 HeadCalibrationPositionOffset;
        protected Quaternion HeadCalibrationRotationOffset = Quaternion.identity;
        protected Quaternion LeftEyeCalibrationRotationOffset = Quaternion.identity;
        protected Quaternion RightEyeCalibrationRotationOffset = Quaternion.identity;
        protected static readonly Dictionary<string, string> MirroredBlendShapesMapping = new()
        {{"eyeBlinkLeft", "eyeBlinkRight"}, {"eyeLookDownLeft", "eyeLookDownRight"}, {"eyeLookInLeft", "eyeLookInRight"}, {"eyeLookOutLeft", "eyeLookOutRight"}, {"eyeLookUpLeft", "eyeLookUpRight"}, {"eyeSquintLeft", "eyeSquintRight"}, {"eyeWideLeft", "eyeWideRight"}, {"eyeBlinkRight", "eyeBlinkLeft"}, {"eyeLookDownRight", "eyeLookDownLeft"}, {"eyeLookInRight", "eyeLookInLeft"}, {"eyeLookOutRight", "eyeLookOutLeft"}, {"eyeLookUpRight", "eyeLookUpLeft"}, {"eyeSquintRight", "eyeSquintLeft"}, {"eyeWideRight", "eyeWideLeft"}, {"jawForward", "jawForward"}, {"jawLeft", "jawRight"}, {"jawRight", "jawLeft"}, {"jawOpen", "jawOpen"}, {"mouthClose", "mouthClose"}, {"mouthFunnel", "mouthFunnel"}, {"mouthPucker", "mouthPucker"}, {"mouthLeft", "mouthRight"}, {"mouthRight", "mouthLeft"}, {"mouthSmileLeft", "mouthSmileRight"}, {"mouthSmileRight", "mouthSmileLeft"}, {"mouthFrownLeft", "mouthFrownRight"}, {"mouthFrownRight", "mouthFrownLeft"}, {"mouthDimpleLeft", "mouthDimpleRight"}, {"mouthDimpleRight", "mouthDimpleLeft"}, {"mouthStretchLeft", "mouthStretchRight"}, {"mouthStretchRight", "mouthStretchLeft"}, {"mouthRollLower", "mouthRollUpper"}, {"mouthRollUpper", "mouthRollLower"}, {"mouthShrugLower", "mouthShrugUpper"}, {"mouthShrugUpper", "mouthShrugLower"}, {"mouthPressLeft", "mouthPressRight"}, {"mouthPressRight", "mouthPressLeft"}, {"mouthLowerDownLeft", "mouthLowerDownRight"}, {"mouthLowerDownRight", "mouthLowerDownLeft"}, {"mouthUpperUpLeft", "mouthUpperUpRight"}, {"mouthUpperUpRight", "mouthUpperUpLeft"}, {"browDownLeft", "browDownRight"}, {"browDownRight", "browDownLeft"}, {"browInnerUp", "browInnerUp"}, {"browOuterUpLeft", "browOuterUpRight"}, {"browOuterUpRight", "browOuterUpLeft"}, {"cheekPuff", "cheekPuff"}, {"cheekSquintLeft", "cheekSquintRight"}, {"cheekSquintRight", "cheekSquintLeft"}, {"noseSneerLeft", "noseSneerRight"}, {"noseSneerRight", "noseSneerLeft"}, {"tongueOut", "tongueOut"}};
        protected static readonly Dictionary<HumanBodyBones, HumanBodyBones> MirroredBonesMapping = new()
        {{HumanBodyBones.Hips, HumanBodyBones.Hips}, {HumanBodyBones.LeftUpperLeg, HumanBodyBones.RightUpperLeg}, {HumanBodyBones.RightUpperLeg, HumanBodyBones.LeftUpperLeg}, {HumanBodyBones.LeftLowerLeg, HumanBodyBones.RightLowerLeg}, {HumanBodyBones.RightLowerLeg, HumanBodyBones.LeftLowerLeg}, {HumanBodyBones.LeftFoot, HumanBodyBones.RightFoot}, {HumanBodyBones.RightFoot, HumanBodyBones.LeftFoot}, {HumanBodyBones.Spine, HumanBodyBones.Spine}, {HumanBodyBones.Chest, HumanBodyBones.Chest}, {HumanBodyBones.Neck, HumanBodyBones.Neck}, {HumanBodyBones.Head, HumanBodyBones.Head}, {HumanBodyBones.LeftShoulder, HumanBodyBones.RightShoulder}, {HumanBodyBones.RightShoulder, HumanBodyBones.LeftShoulder}, {HumanBodyBones.LeftUpperArm, HumanBodyBones.RightUpperArm}, {HumanBodyBones.RightUpperArm, HumanBodyBones.LeftUpperArm}, {HumanBodyBones.LeftLowerArm, HumanBodyBones.RightLowerArm}, {HumanBodyBones.RightLowerArm, HumanBodyBones.LeftLowerArm}, {HumanBodyBones.LeftHand, HumanBodyBones.RightHand}, {HumanBodyBones.RightHand, HumanBodyBones.LeftHand}, {HumanBodyBones.LeftToes, HumanBodyBones.RightToes}, {HumanBodyBones.RightToes, HumanBodyBones.LeftToes}, {HumanBodyBones.LeftEye, HumanBodyBones.RightEye}, {HumanBodyBones.RightEye, HumanBodyBones.LeftEye}, {HumanBodyBones.Jaw, HumanBodyBones.Jaw}, {HumanBodyBones.LeftThumbProximal, HumanBodyBones.RightThumbProximal}, {HumanBodyBones.LeftThumbIntermediate, HumanBodyBones.RightThumbIntermediate}, {HumanBodyBones.LeftThumbDistal, HumanBodyBones.RightThumbDistal}, {HumanBodyBones.RightThumbProximal, HumanBodyBones.LeftThumbProximal}, {HumanBodyBones.RightThumbIntermediate, HumanBodyBones.LeftThumbIntermediate}, {HumanBodyBones.RightThumbDistal, HumanBodyBones.LeftThumbDistal}, {HumanBodyBones.LeftIndexProximal, HumanBodyBones.RightIndexProximal}, {HumanBodyBones.LeftIndexIntermediate, HumanBodyBones.RightIndexIntermediate}, {HumanBodyBones.LeftIndexDistal, HumanBodyBones.RightIndexDistal}, {HumanBodyBones.RightIndexProximal, HumanBodyBones.LeftIndexProximal}, {HumanBodyBones.RightIndexIntermediate, HumanBodyBones.LeftIndexIntermediate}, {HumanBodyBones.RightIndexDistal, HumanBodyBones.LeftIndexDistal}, {HumanBodyBones.LeftMiddleProximal, HumanBodyBones.RightMiddleProximal}, {HumanBodyBones.LeftMiddleIntermediate, HumanBodyBones.RightMiddleIntermediate}, {HumanBodyBones.LeftMiddleDistal, HumanBodyBones.RightMiddleDistal}, {HumanBodyBones.RightMiddleProximal, HumanBodyBones.LeftMiddleProximal}, {HumanBodyBones.RightMiddleIntermediate, HumanBodyBones.LeftMiddleIntermediate}, {HumanBodyBones.RightMiddleDistal, HumanBodyBones.LeftMiddleDistal}, {HumanBodyBones.LeftRingProximal, HumanBodyBones.RightRingProximal}, {HumanBodyBones.LeftRingIntermediate, HumanBodyBones.RightRingIntermediate}, {HumanBodyBones.LeftRingDistal, HumanBodyBones.RightRingDistal}, {HumanBodyBones.RightRingProximal, HumanBodyBones.LeftRingProximal}, {HumanBodyBones.RightRingIntermediate, HumanBodyBones.LeftRingIntermediate}, {HumanBodyBones.RightRingDistal, HumanBodyBones.LeftRingDistal}, {HumanBodyBones.LeftLittleProximal, HumanBodyBones.RightLittleProximal}, {HumanBodyBones.LeftLittleIntermediate, HumanBodyBones.RightLittleIntermediate}, {HumanBodyBones.LeftLittleDistal, HumanBodyBones.RightLittleDistal}, {HumanBodyBones.RightLittleProximal, HumanBodyBones.LeftLittleProximal}, {HumanBodyBones.RightLittleIntermediate, HumanBodyBones.LeftLittleIntermediate}, {HumanBodyBones.RightLittleDistal, HumanBodyBones.LeftLittleDistal}, {HumanBodyBones.UpperChest, HumanBodyBones.UpperChest}};
        internal List<string> inputBlendShapes;
        public virtual void Calibrate()
        {
            throw new NotImplementedException();
        }

        protected override void OnCreate()
        {
            throw new NotImplementedException();
        }

        protected override void OnCreateCharacterDaemon()
        {
            throw new NotImplementedException();
        }

        protected override void OnDestroy()
        {
            throw new NotImplementedException();
        }

        public override void OnUpdate()
        {
            throw new NotImplementedException();
        }

        public override void OnLateUpdate()
        {
            throw new NotImplementedException();
        }

        protected abstract bool UpdateRawData();
        protected Vector3 MirrorPosition(Vector3 position)
        {
            throw new NotImplementedException();
        }

        protected Quaternion MirrorRotation(Quaternion rotation)
        {
            throw new NotImplementedException();
        }

        protected Vector3 MirrorBonePosition(Vector3[] positions, HumanBodyBones bone)
        {
            throw new NotImplementedException();
        }

        protected Quaternion MirrorBoneRotation(Quaternion[] rotations, HumanBodyBones bone)
        {
            throw new NotImplementedException();
        }
    }
}