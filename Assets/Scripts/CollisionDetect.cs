﻿ using System.Collections;
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

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Yessss");
        GameObject temp = GameObject.Find("WeightBar");
        WeightCounter counter = temp.GetComponent<WeightCounter>();

        if (col.gameObject.tag == "pollution")
        {
            counter.CurrentWeight += 5;
            Destroy(col.gameObject);
        }
    }
}
