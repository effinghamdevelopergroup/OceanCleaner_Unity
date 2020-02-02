using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PollutionDestroy : MonoBehaviour
{
    WeightCounter counter;

    void Start()
    {
        GameObject temp = GameObject.Find("WeightBar");
        counter = temp.GetComponent<WeightCounter>();
    }

    void OnDestroy()
    {
        counter.PickUpTrash(5);
    }
}
