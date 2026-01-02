using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaReductionMesh
{
    public class PolygonLinkReduction
    {
        protected MeshData meshData;
        public class Point
        {
            public MeshData.ShareVertex shareVertex;
            public Point nearPoint;
            public float nearDist;
        }

        List<Point> pointList = new List<Point>();
        Dictionary<MeshData.ShareVertex, Point> pointDict = new Dictionary<MeshData.ShareVertex, Point>();
        public PolygonLinkReduction(float length)
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

        void AddPoint(MeshData.ShareVertex sv)
        {
            throw new NotImplementedException();
        }

        Point GetPoint(MeshData.ShareVertex sv)
        {
            throw new NotImplementedException();
        }

        void Remove(Point p)
        {
            throw new NotImplementedException();
        }

        void SearchNearPointAll()
        {
            throw new NotImplementedException();
        }

        void SearchNearPoint(Point p)
        {
            throw new NotImplementedException();
        }

        Point GetNearPointPair()
        {
            throw new NotImplementedException();
        }
    }
}