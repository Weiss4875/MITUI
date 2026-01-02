using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaReductionMesh
{
    public class NearPointReduction
    {
        protected MeshData meshData;
        public class Point
        {
            public MeshData.ShareVertex shareVertex;
            public Vector3 pos;
            public Vector3Int grid;
            public Point nearPoint;
            public float nearDist;
        }

        List<Point> pointList = new List<Point>();
        protected Dictionary<Vector3Int, List<Point>> gridMap = new Dictionary<Vector3Int, List<Point>>();
        protected float gridSize = 0.05f;
        float searchRadius;
        Dictionary<Point, List<Point>> nearPointDict = new Dictionary<Point, List<Point>>();
        public NearPointReduction(float radius = 0.05f)
        {
            throw new NotImplementedException();
        }

        public int PointCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Create(MeshData meshData)
        {
            throw new NotImplementedException();
        }

        public void Reduction()
        {
            throw new NotImplementedException();
        }

        Point AddPoint(MeshData.ShareVertex sv, Vector3 pos)
        {
            throw new NotImplementedException();
        }

        void AddGrid(Point p)
        {
            throw new NotImplementedException();
        }

        void RemoveGrid(Point p)
        {
            throw new NotImplementedException();
        }

        void Move(Point p, Vector3 newpos)
        {
            throw new NotImplementedException();
        }

        void Remove(Point p)
        {
            throw new NotImplementedException();
        }

        protected Vector3Int GetGridPos(Vector3 pos)
        {
            throw new NotImplementedException();
        }

        void SearchNearPointAll()
        {
            throw new NotImplementedException();
        }

        void SearchNearPoint(Point p, float radius, Point ignorePoint)
        {
            throw new NotImplementedException();
        }

        Point GetNearPointPair()
        {
            throw new NotImplementedException();
        }
    }
}