using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPlaneGenerator : MonoBehaviour
{
    public float Size = 1;
    public int GridSize = 15;

    private MeshFilter Filter;

    // Start is called before the first frame update
    private void Start()
    {
        Filter = GetComponent<MeshFilter>();
        Filter.mesh = GenerateMesh();
    }

    private Mesh GenerateMesh()
    {
        Mesh mesh = new Mesh();

        List<Vector3> verticies = new List<Vector3>();
        List<Vector3> normals = new List<Vector3>();
        List<Vector2> uvs = new List<Vector2>();

        for (int x = 0; x < GridSize + 1; x++)
        {
            for (int y = 0; y < GridSize + 1; y++)
            {
                verticies.Add(new Vector3(-Size * 0.5f + Size * (x / ((float)GridSize)), 
                                          0, 
                                          -Size * 0.5f + Size * (y / ((float)GridSize))));
                normals.Add(Vector3.up);
                uvs.Add(new Vector2(x / (float)GridSize, y / (float)GridSize));
            }
        }

        var triangles = new List<int>();
        var vertCount = GridSize + 1;

        for(int i = 0; i < vertCount * vertCount - vertCount; i++)
        {
            if ((i + 1) % vertCount == 0)
            {
                continue;
            }
            triangles.AddRange(new List<int>() { i + 1 + vertCount, i + vertCount, i, i, i+1, i + vertCount + 1});
        }

        mesh.SetVertices(verticies);
        mesh.SetNormals(normals);
        mesh.SetUVs(0, uvs);
        mesh.SetTriangles(triangles, 0);

        return mesh;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
