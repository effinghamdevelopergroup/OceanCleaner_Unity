using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{
    public bool Turning = false;
    public float Speed;
    public float MaxSpeed;
    public float Acceloration;
    public float Decceloration;
    public Vector3 Position;
    public Rigidbody Body;
    private float CurrentSpeed;
    public GameObject target;
    public float turnSpeed;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Target");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            CurrentSpeed = Mathf.Lerp(CurrentSpeed, MaxSpeed, Acceloration);
        }

        else if (Input.GetAxis("Vertical") < 0)
        {
            CurrentSpeed = Mathf.Lerp(CurrentSpeed, -MaxSpeed, Acceloration);
        }
        else
        {
            CurrentSpeed = Mathf.Lerp(CurrentSpeed, 0, Decceloration);
        }

        if (Input.GetMouseButton(0))
        {
            
            Turning = transform;
            LocatePosition();
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Rotate(0, Time.deltaTime * turnSpeed,0);
        }

        else if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Rotate(0, -Time.deltaTime * turnSpeed, 0);
        }

        UpdatePosition();

        //RotateTowardPosition();
    }

    private void UpdatePosition()
    {
        transform.Translate(Vector3.forward * CurrentSpeed);
    }

    private void RotateTowardPosition()
    {
        if (Turning)
        {
            Quaternion rotation = Quaternion.LookRotation(Position - transform.position, Vector3.forward);

            rotation.x = 0f;
            rotation.z = 0f;

            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime );

            Vector2 toVector = new Vector2(Position.x,Position.z) - new Vector2(transform.position.x,transform.position.z);
            float angleToTarget = Vector2.Angle(transform.up, toVector);

            if (transform.rotation.y> angleToTarget-11 && transform.rotation.y < angleToTarget + 11)
            {
                Turning = false;
                Debug.Log("yo!");
            }

        }
    }

    private void LocatePosition()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray , out hit, 1000))
        {
            Position = new Vector3(hit.point.x, hit.point.y, hit.point.z);
            Debug.Log(Position);
            target.transform.position = Position;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Target")
        {
            Turning = false;
        }
    }

}
