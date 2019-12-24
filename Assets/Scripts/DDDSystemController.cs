using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDDSystemController : MonoBehaviour
{

public float speed;

float x;
float y;
float z;


    void Update()
    {

        transform.rotation = Quaternion.Euler(x,y,0);

            if(Input.GetKey(KeyCode.LeftArrow)){
                y+= speed;
            }
            if(Input.GetKey(KeyCode.RightArrow)){
                y-= speed;
            }
            if(Input.GetKey(KeyCode.UpArrow)){
                x-= speed;
            }
            if(Input.GetKey(KeyCode.DownArrow)){
                x+= speed;
            }
    }
}
