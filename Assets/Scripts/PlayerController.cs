using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

float speed = .1f;

float x;
float y;
float z;
float theta=0;
float fi=Mathf.PI;
    float r=.5f;

    void Start()
    {
        
    }

    void Update()
    {
            x = r*Mathf.Sin(theta)*Mathf.Cos(fi);
            y = r*Mathf.Sin(theta)*Mathf.Sin(fi);
            z = r*Mathf.Cos(theta);

        transform.position = new Vector3(x,y,z);

            if(Input.GetKey(KeyCode.LeftArrow)){
                theta += speed;
            }
            if(Input.GetKey(KeyCode.RightArrow)){
                theta -= speed;
            }
            if(Input.GetKey(KeyCode.UpArrow)){
                fi += speed;
            }
            if(Input.GetKey(KeyCode.DownArrow)){
                fi -= speed;
            }
    }
}
