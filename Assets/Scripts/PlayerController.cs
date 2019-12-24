using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody rb;
        Vector3 pos;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        pos = new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"),
            rb.velocity.z);
    }

    void FixedUpdate() {
        rb.velocity = pos; 


    }
}
