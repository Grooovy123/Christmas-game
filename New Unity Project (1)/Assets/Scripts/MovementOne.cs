using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementOne : MonoBehaviour
{
    //Basic movement controls
    public int jumpConst = 0;

    private bool canJump;
    private Rigidbody selfRigidbody;

    public bool isGrounded;
    void Start()
    {
        selfRigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        MovementFunc();
        Jumping();

    }

    private void Jumping()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            selfRigidbody.AddForce(0, jumpConst, 0, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    private void MovementFunc()
    {
        Vector3 downForce = new Vector3(0, 0, 0);
        selfRigidbody.AddForce(downForce);

        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.LeftArrow))
            rb.AddForce(Vector3.left * 50);
        if (Input.GetKey(KeyCode.RightArrow))
            rb.AddForce(Vector3.right * 50);
        //if (Input.GetKey(KeyCode.W))
            //rb.AddForce(Vector3.forward * 50);
        if (Input.GetKey(KeyCode.DownArrow))
            rb.AddForce(Vector3.down * 100);
    }

    void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
}