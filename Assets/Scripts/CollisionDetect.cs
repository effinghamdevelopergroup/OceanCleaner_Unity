 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetect : MonoBehaviour
{
    

     void Start()
    {

    }

    void Update()
    {
    }

    void OnCollsionEnter(Collision col)
    {
        GameObject temp = GameObject.Find("WeightBar");
        WeightCounter counter = temp.GetComponent<WeightCounter>();

        if (col.gameObject.tag == "pollution")
        {
            Destroy(col.gameObject);
        }
    }
}
