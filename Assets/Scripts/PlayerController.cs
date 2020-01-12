using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody rb;
    
    Vector3 pos;
        Vector3 verticalSense;
        Vector3 horizontalSense;



    void Update()
    {
        horizontalSense = (Input.GetKey("d"))? Vector3.right :
                          (Input.GetKey("a"))? Vector3.left  : new Vector3(0,0,0) ;
        verticalSense = (Input.GetKey("w"))? Vector3.up   :
                        (Input.GetKey("s"))? Vector3.down : new Vector3(0,0,0) ;
    

        
        pos = horizontalSense+verticalSense;
        transform.Translate(0.02f*(pos));
    }


}
