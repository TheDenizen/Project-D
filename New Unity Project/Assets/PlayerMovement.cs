using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public int ConstantSpeed = 0;
    public int MovementSpeed = 2000;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ConstantSpeed * Time.deltaTime);

        if (Input.GetKey("w"))
        {
            //rigidbody.velocity = Vector3.zero;
            //rigidbody.angularVelocity = Vector3.zero;
            rb.AddForce(0, 0, MovementSpeed * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            //rigidbody.velocity = Vector3.zero;
            //rigidbody.angularVelocity = Vector3.zero;
            rb.AddForce(-MovementSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("s"))
        {
            //rigidbody.velocity = Vector3.zero;
            //rigidbody.angularVelocity = Vector3.zero;
            rb.AddForce(0, 0, -MovementSpeed * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            //rigidbody.velocity = Vector3.zero;
            //rigidbody.angularVelocity = Vector3.zero;
            rb.AddForce(MovementSpeed * Time.deltaTime, 0, 0);
        }
    }
}
