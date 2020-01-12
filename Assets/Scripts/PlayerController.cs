using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody rb;
    
    Vector3 pos;
        float verticalSense;
        float horizontalSense;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        horizontalSense = (Input.GetKey("d"))?1:
                          (Input.GetKey("a"))?-1:0;
        verticalSense = (Input.GetKey("w"))?1:
                        (Input.GetKey("s"))?-1:0;
    

        
        pos = new Vector3(horizontalSense, verticalSense, rb.velocity.z);
    }

    void FixedUpdate() {
        rb.velocity = pos; 


    }
}
