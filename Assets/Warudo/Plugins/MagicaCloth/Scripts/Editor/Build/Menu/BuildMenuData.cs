using UnityEditor;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class BuildMenuData
    {
        const string SettingDataSaveName = "MagicaClothBuildSettings";
        public int TargetMode = 1;
        public bool Prefab = true;
        public bool Scene = true;
        public bool BoneCloth = true;
        public bool BoneSpring = true;
        public bool MeshCloth = true;
        public bool MeshSpring = true;
        public bool RenderDeformer = true;
        public bool VirtualDeformer = true;
        public bool ForceBuild = false;
        public bool NotCreated = true;
        public bool UpgradeFormatAndAlgorithm = true;
        public bool VerificationOnly = false;
        public bool ErrorStop = false;
        public void Load()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}