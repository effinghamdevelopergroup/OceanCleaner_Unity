using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasteCounter : MonoBehaviour
{
    public int waste = 0;
    private SpriteRenderer m_SpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        //Set the GameObject's Color quickly to a set Color (blue)

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void addWaste(int v)
    {
        waste += v;
        m_SpriteRenderer.color = new Color(waste*.005f, 1, 1);
        Debug.Log(waste);
    }
}
