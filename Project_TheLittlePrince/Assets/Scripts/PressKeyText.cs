using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressKeyText : MonoBehaviour
{
    //private int frame=0;

    public GameObject g;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(frame<100){
            frame++;
        }
        else{
            g.SetActive(true);
        }*/
        if(Time.time>5){
            g.SetActive(true);
            if(Input.GetKey(KeyCode.G)){
                SceneManager.LoadScene("TLP Planet");
            }
        }
    }
}
