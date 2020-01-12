using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDDPlayerController : MonoBehaviour
{

float speed = .1f;

float x;
float y;
float z;
float theta=0;
float fi=Mathf.PI;
    float r=.5f;


    void Update()
    {
            theta = (Input.GetKey("d")) ? theta+=speed :
                    (Input.GetKey("a")) ? theta-=speed : theta;
            fi = (Input.GetKey("w")) ? fi+=speed :
                 (Input.GetKey("s")) ? fi-=speed : fi;



            x = r*Mathf.Sin(theta)*Mathf.Cos(fi);
            y = r*Mathf.Sin(theta)*Mathf.Sin(fi);
            z = r*Mathf.Cos(theta);
        transform.position = new Vector3(x,y,z);

    }

     /* void Update()
    {
                theta = (Input.GetKey("d")) ? 1 : 
                        (Input.GetKey("a")) ? -1 : 0;
                fi = (Input.GetKey("w")) ? 1 : 
                     (Input.GetKey("s")) ? -1 : 0;

            xSense = r*Mathf.Sin(theta)*Mathf.Cos(fi);
            ySense = r*Mathf.Sin(theta)*Mathf.Sin(fi);
            zSense = r*Mathf.Cos(theta);

        pos = new Vector3(xSense, ySense, zSense);
    }*/
}
