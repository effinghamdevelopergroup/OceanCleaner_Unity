using System;
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
        GameObject temp = GameObject.Find("WeightBar");
        WeightBar = temp.GetComponent<Slider>();
        MaxWeight = 1000d;
        WeightBar.maxValue = (float)MaxWeight;
        CurrentWeight = 10d;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateWeightBar();
    }

    public void PickUpTrash(double weight)
    {
        CurrentWeight += weight;
    }

    void UpdateWeightBar()
    {
        Console.WriteLine((float)CurrentWeight);
        WeightBar.value = (float)CurrentWeight;
    }
}
