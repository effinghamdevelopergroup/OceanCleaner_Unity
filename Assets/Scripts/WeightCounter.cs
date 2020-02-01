using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeightCounter : MonoBehaviour
{
    public double MaxWeight;
    public double CurrentWeight;

    public Slider WeightBar;

    // Start is called before the first frame update
    void Start()
    {
        MaxWeight = 10000d;
        CurrentWeight = 10d;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            PickUpTrash(5);
        }
    }

    void PickUpTrash(double weight)
    {
        CurrentWeight += weight;
    }


}
