using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{

    void OnTriggerEnter(Collider other) {
        Rigidbody rb = other.GetComponent<Rigidbody>();

        
        float dif = 0.05f;
            float x = (other.transform.position.x < 0) ?
            rb.transform.position.x+dif : 
            rb.transform.position.x-dif;

        rb.transform.position = new Vector3(
            x * -1,
            rb.transform.position.y,
            rb.transform.position.z);

        //other.GetComponent<Transform>().rotation = Quaternion.Euler(0,0,90);
        rb.transform.rotation = Quaternion.Euler(0,0,
        rb.transform.rotation.z += 90);
    }

}
 ////ROTATION IS IMPORTANT