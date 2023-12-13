using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkSoundEarth : MonoBehaviour
{
    //오디오
    AudioSource audioSrc;
    
    // Start is called before the first frame update
    void Awake()
    {
        audioSrc=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<EarthWalkerController>().IsWalking){
            if(!audioSrc.isPlaying){
                audioSrc.Play();
            }
        }
        else{
            audioSrc.Stop();
        }
    }
}