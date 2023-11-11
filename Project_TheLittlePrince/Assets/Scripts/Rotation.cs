using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    float degree;
    //public float speed=1.0f;
    // Start is called before the first frame update
    void Start()
    {
        degree=0f;
    }

    // Update is called once per frame
    void Update()
    {
        degree+=Time.deltaTime;
        if(degree>360)
            degree=0;
        
        RenderSettings.skybox.SetFloat("_Rotation",degree);
        //transform.Rotate(Vector3.down*speed*Time.deltaTime);
    }
}
