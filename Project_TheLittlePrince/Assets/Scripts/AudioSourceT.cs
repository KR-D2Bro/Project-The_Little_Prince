using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceT : MonoBehaviour
{
    public AudioClip[] audio;
    public GameObject questManager;
    QuestManager qm;

    private AudioSource BGM;

    bool IsPlay=false;
    void Start()
    {
        qm=questManager.GetComponent<QuestManager>();

        BGM = gameObject.GetComponent<AudioSource>();
        BGM.loop = true;
        BGM.clip=audio[0];
        BGM.Play();
    }
    
    void Update(){
        if(qm.IsNight&&!IsPlay){
            BGM.clip=audio[1];
            BGM.Play();
            BGM.volume = Mathf.Clamp(0.15f, 0f, 1f);
            IsPlay=true;
        }
    }
}
