using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManagement : MonoBehaviour
{

    public GameObject Tile;
    public int GridX;
    public int GridY;

    // Start is called before the first frame update
    void Start()
    {
        for (int y = 0; y < GridY; y++)
        {
            for (int x = 0; x < GridX; x++)
            {
                Instantiate(Tile, new Vector3(x * 9, 0, y*9), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
