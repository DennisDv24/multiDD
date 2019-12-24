using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitPosition : MonoBehaviour
{   

public bool xneg;
public bool yneg;
    int xoperator;
    int yoperator;

    void Start()
    {
            print("in:"+transform.position);

                xoperator = xneg?-1:1;
                yoperator = yneg?-1:1;

            float posx = ((Mathf.Sqrt(2)/4)+(0.1f*Mathf.Sin(Mathf.PI/4)));
            float posy = ((Mathf.Sqrt(2)/4)+(0.1f*Mathf.Sin(Mathf.PI/4)));
            float posz = -6.5f;

        Vector3 pos = new Vector3(posx, posy, posz); 

    transform.position = pos;

        print("f:"+transform.position);

            //state.rotation = Quaternion.Euler(-180,0,-45);
            
            //transform.rotation = Quaternion.Euler(180,0,180-45);
    }

}
