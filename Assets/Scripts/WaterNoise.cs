using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterNoise : MonoBehaviour
{
    public float Power = 3;
    public float Scale = 1;
    public float TimeScale = 1;

    private float XOffset;
    private float YOffset;
    private MeshFilter MF;

    // Start is called before the first frame update
    void Start()
    {
        MF = GetComponent<MeshFilter>();
        MakeNoise();
    }

    void MakeNoise()
    {
        Vector3[] verticies = MF.mesh.vertices;

        for (int i = 0; i < verticies.Length; i++)
        {
            verticies[i].y = CalculateHeight(verticies[i].x, verticies[i].z) * Power;
        }
        MF.mesh.vertices = verticies;
    }

    private float CalculateHeight(float x, float z)
    {
        float xCord = x * Scale + XOffset;
        float yCord = z * Scale + YOffset;

        return Mathf.PerlinNoise(xCord, yCord);
    }

    // Update is called once per frame
    void Update()
    {
        MakeNoise();
        XOffset += Time.deltaTime * TimeScale;
        YOffset += Time.deltaTime * TimeScale;
    }
}
