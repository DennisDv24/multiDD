using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitPosition : MonoBehaviour
{   

public bool xneg;
public bool yneg;
    int xoperator;
    int yoperator;

    void FixedUpdate()
    {
                xoperator = xneg?-1:1;
                yoperator = yneg?-1:1;

            float posx = xoperator*((Mathf.Sqrt(2)/4)+(0.1f*Mathf.Sin(Mathf.PI/4)));
            float posy = yoperator*((Mathf.Sqrt(2)/4)+(0.1f*Mathf.Sin(Mathf.PI/4)));
            float posz = -6.5f;

        Vector3 pos = new Vector3(posx, posy, posz); 

    transform.position = pos;
            
    }

}
