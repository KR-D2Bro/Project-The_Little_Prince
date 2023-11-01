using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkSound : MonoBehaviour
{
    //다른 스크립트 접근
    GameObject obj;
    //오디오
    AudioSource audioSrc;
    
    // Start is called before the first frame update
    void Awake()
    {
        obj=GameObject.Find("TLP");
        audioSrc=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(obj.GetComponent<PlanetaryWalkerController>().IsWalking){
            if(!audioSrc.isPlaying){
                audioSrc.Play();
            }
        }
        else{
            audioSrc.Stop();
        }
    }
}
