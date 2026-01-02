using System;
using Object = UnityEngine.Object;

namespace Warudo.Plugins.Core.Assets.MotionCapture
{
    public abstract class GenericFullBodyTrackerAsset : GenericTrackerAsset
    {
        protected override bool UseCharacterDaemon => throw new NotImplementedException();
        protected override bool UseHeadIK => throw new NotImplementedException();
        protected override bool UseCharacterDaemonBones => throw new NotImplementedException();
        protected override bool CanCalibrate => throw new NotImplementedException();
        protected override bool UseEyeInputs => throw new NotImplementedException();
    }
}