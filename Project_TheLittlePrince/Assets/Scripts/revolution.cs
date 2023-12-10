using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revolution : MonoBehaviour
{
    public GameObject Planet;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Planet.transform.position,Vector3.down,speed*Time.deltaTime);
    }
}
