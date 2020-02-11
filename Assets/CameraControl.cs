using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    GameObject player;
    public GameObject Top;
    public GameObject Bottom;
    public GameObject Right;
    public GameObject Left;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x;
        float z = transform.position.z;

        if (player.transform.position.x > Left.transform.position.x) {
            if (player.transform.position.x < Right.transform.position.x)
            {
                x = player.transform.position.x;
            }
        }

        if (player.transform.position.z > Bottom.transform.position.z)
        {
            if (player.transform.position.z < Top.transform.position.z)
            {
                z = player.transform.position.z;
            }
        }

        transform.position = new Vector3(x,transform.position.y,z);


    }
}
