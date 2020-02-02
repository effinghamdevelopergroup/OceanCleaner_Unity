using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WasteCounter : MonoBehaviour
{
    public int waste = 40;
    Renderer rend;
    SpriteRenderer sp;

    void Start()
    {
        rend = GetComponent<Renderer>();
        sp = GetComponent<SpriteRenderer>();
        rend.material.color = new Color(waste * .006f, 1 - waste * .005f, .9F - waste * .005f);
        sp.color = new Color(waste * .006f, 1 - waste * .005f, .9F - waste * .005f);
    }

    // Update is called once per frame
    void Update()
    {
        if (waste > 190)
        {
            SceneManager.LoadScene(2);
        }
    }

    internal void addWaste(int v)
    {
        waste += v;
        rend.material.color = new Color(waste*.006f, 1-waste * .005f, .9F- waste * .005f);
        sp.color = new Color(waste * .006f, 1 - waste * .005f, .9F - waste * .005f);
        Debug.Log(waste);
    }
}
