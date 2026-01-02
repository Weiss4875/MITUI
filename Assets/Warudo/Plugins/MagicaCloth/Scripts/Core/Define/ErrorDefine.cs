using System.Text;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public static partial class Define
    {
        public enum Error
        {
            None = 0,
            Cancel = 1,
            EmptyData = 100,
            InvalidDataHash = 101,
            TooOldDataVersion = 102,
            HigherDataVersion = 103,
            MeshDataNull = 200,
            MeshDataHashMismatch = 201,
            MeshDataVersionMismatch = 202,
            ClothDataNull = 300,
            ClothDataHashMismatch = 301,
            ClothDataVersionMismatch = 302,
            ClothSelectionHashMismatch = 400,
            ClothSelectionVersionMismatch = 401,
            ClothTargetRootCountMismatch = 500,
            UseTransformNull = 600,
            UseTransformCountZero = 601,
            UseTransformCountMismatch = 602,
            DeformerNull = 700,
            DeformerHashMismatch = 701,
            DeformerVersionMismatch = 702,
            DeformerCountZero = 703,
            DeformerCountMismatch = 704,
            VertexCountZero = 800,
            VertexUseCountZero = 801,
            VertexCountMismatch = 802,
            RootListCountMismatch = 900,
            SelectionDataCountMismatch = 1000,
            SelectionCountZero = 1001,
            CenterTransformNull = 1100,
            SpringDataNull = 1200,
            SpringDataHashMismatch = 1201,
            SpringDataVersionMismatch = 1202,
            TargetObjectNull = 1300,
            SharedMeshNull = 1400,
            SharedMeshCannotRead = 1401,
            SharedMeshDifferent = 1402,
            SharedMeshDifferentVertexCount = 1403,
            MeshOptimizeMismatch = 1500,
            MeshVertexCount65535Over = 1501,
            MeshKeepQuads = 1502,
            BoneListZero = 1600,
            BoneListNull = 1601,
            RendererNotFound = 1700,
            MeshFilterNotFound = 1701,
            BuildNoTransformList = 8000,
            BuildReadOnlyPrefab = 8001,
            BuildFailedSaveAssets = 8002,
            BuildPrefabCannotSaved = 8003,
            BuildNotSceneObject = 8004,
            BuildInvalidComponent = 8100,
            BuildInvalidData = 8101,
            BuildInvalidMeshData = 8102,
            BuildInvalidGameObject = 8103,
            BuildInvalidPrefab = 8104,
            BuildInvalidRenderDeformer = 8105,
            BuildInvalidScene = 8106,
            BuildInvalidSelection = 8107,
            BuildMissingDeformer = 8200,
            BuildMissingSelection = 8201,
            BuildMissingMesh = 8202,
            BuildMissingScriptOnPrefab = 8203,
            OverlappingTransform = 20000,
            AddOverlappingTransform = 20001,
            OldDataVersion = 20002,
            OldAlgorithm = 20003,
        }

        public static bool IsNormal(Error err)
        {
            throw new NotImplementedException();
        }

        public static bool IsError(Error err)
        {
            throw new NotImplementedException();
        }

        public static bool IsWarning(Error err)
        {
            throw new NotImplementedException();
        }

        public static string GetErrorMessage(Error err)
        {
            throw new NotImplementedException();
        }
    }
}