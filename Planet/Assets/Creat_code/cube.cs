﻿using UnityEngine;
using UnityEditor;
using System.Collections;
[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class cube : MonoBehaviour
{
    public int xSize, ySize, zSize;
    private Mesh mesh;
    private Vector3[] vertices;
    private void Reset() { Generate(); }
    private void OnValidate() { Generate(); }
    private void Generate()
    {
        GetComponent<MeshFilter>().mesh = mesh = new Mesh();
        mesh.name = "Procedural Cube";
        int cornerVertices = 8;
        int edgeVertices = (xSize + ySize + zSize - 3) * 4;
        int faceVertices = (
            (xSize - 1) * (ySize - 1) +
            (xSize - 1) * (zSize - 1) +
            (ySize - 1) * (zSize - 1)) * 2;
        vertices = new Vector3[cornerVertices + edgeVertices + faceVertices];
        int v = 0;
        for (int x = 0; x <= xSize; x++)
        {
            vertices[v++] = new Vector3(x, 0, 0);
        }
    }
    private void OnDrawGizmos()
    {
        if (vertices == null)
        {
            return;
        }
        Gizmos.color = Color.black;
        for (int i = 0; i < vertices.Length; i++)
        {
            Gizmos.DrawSphere(vertices[i], 0.1f);
        }
    }
}