using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{
    public float Speed;
    public Vector3 Position;
    public Rigidbody Body;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            Body.AddForce(Vector3.forward, ForceMode.Impulse);
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            Body.AddForce(Vector3.forward * -1, ForceMode.Impulse);
        }

        if (Input.GetMouseButton(0))
        {
            LocatePosition();
        }

        RotateTowardPosition();
    }

    private void RotateTowardPosition()
    {
        //if(Vector3.Distance(transform.position, Position) > 1)
        //{
            Quaternion rotation = Quaternion.LookRotation(Position - transform.position, Vector3.forward);

            rotation.x = 0f;
            rotation.z = 0f;

            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime + 10);
        //}
    }

    private void LocatePosition()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray , out hit, 1000))
        {
            Position = new Vector3(hit.point.x, hit.point.y, hit.point.z);
            Debug.Log(Position);
        }
    }
}
