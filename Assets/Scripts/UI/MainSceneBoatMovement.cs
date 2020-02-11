using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneBoatMovement : MonoBehaviour
{
    float Speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((transform.forward * UnityEngine.Time.deltaTime) * Speed);
    }
}
