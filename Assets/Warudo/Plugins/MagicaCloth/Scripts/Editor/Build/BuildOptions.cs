using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class BuildOptions
    {
        public bool buildBoneCloth = true;
        public bool buildBoneSpring = true;
        public bool buildMeshCloth = true;
        public bool buildMeshSpring = true;
        public bool buildRenderDeformer = true;
        public bool buildVirtualDeformer = true;
        public bool forceBuild = false;
        public bool notCreated = true;
        public bool upgradeFormatAndAlgorithm = true;
        public bool includeInactive = true;
        public bool errorStop = false;
        public bool verificationOnly = false;
    }
}