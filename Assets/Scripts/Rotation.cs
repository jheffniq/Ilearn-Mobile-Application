using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float RotationSpeed;
    public bool rotate;
    public bool Saturn;

    void Start()
    {

    }

    void Update()
    {
        if(rotate){
            if(Saturn){
                transform.Rotate(new Vector3(0,0,-1) * RotationSpeed * Time.deltaTime);
            }
            else{
                transform.Rotate(new Vector3(0,0,-1) * RotationSpeed * Time.deltaTime);
            }
        }
    }
}
