using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallJump : MonoBehaviour
{

    bool jumping;
    private Rigidbody Jumpy;

    // Use this for initialization
    void Start()
    {
        jumping = false;
        Jumpy = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && jumping == false)
        {
            Jumpy.velocity = new Vector3(0f, 5f, 0f);
            jumping = true;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            jumping = false;
        }
    }

}