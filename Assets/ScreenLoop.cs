using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenLoop : MonoBehaviour
{

    GameObject player;
    public GameObject Top;
    public GameObject Bottom;
    public GameObject Right;
    public GameObject Left;

    public GameObject InnerTop;
    public GameObject InnerBottom;
    public GameObject InnerRight;
    public GameObject InnerLeft;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        // Start is called before the first frame update

        
    }

    // Update is called once per frame
    void Update()
    {
        float x = player.transform.position.x;
        float z = player.transform.position.z;
        float newx= player.transform.position.x;
        float newz=player.transform.position.z;
        if (x < Left.transform.position.x)
        {
            newx = InnerRight.transform.position.x;
        }
        if (x >Right.transform.position.x)
        {
            newx = InnerLeft.transform.position.x;
        }
        if (z < Bottom.transform.position.z)
        {
            newz = InnerTop.transform.position.z;
        }
        if (z > Top.transform.position.z)
        {
            newz = InnerBottom.transform.position.z;
        }


        transform.position = new Vector3(newx, transform.position.y, newz);

    }
}
