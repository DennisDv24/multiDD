using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{

    void OnTriggerEnter(Collider other) {

        
        float dif = 0.05f;
            float x = (other.transform.position.x < 0) ?
            other.transform.position.x+dif : 
            other.transform.position.x-dif;

        other.transform.position = new Vector3(
            x * -1,
            other.transform.position.y,
            other.transform.position.z);

        //other.GetComponent<Transform>().rotation = Quaternion.Euler(0,0,90);
        other.transform.rotation =  Quaternion.Euler(0,0,90);
        //rb.transform.rotation.z += 90;
        
        }

}
 ////ROTATION IS IMPORTANT


 ////FIX