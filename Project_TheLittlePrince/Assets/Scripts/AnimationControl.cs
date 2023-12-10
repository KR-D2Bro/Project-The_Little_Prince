using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    Animator anim;

    public GameObject questManager;
    QuestManager qm;

    bool Take=false;
    bool Clap=false;
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
        qm=questManager.GetComponent<QuestManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Take=qm.IsTake;
        Clap=qm.IsClap;

        if(Take){
            anim.SetBool("Take",true);
            qm.IsTake=false;
        }
        else{
            anim.SetBool("Take",false);
        }

        if(Clap){
            anim.SetBool("Clap",true);
            qm.IsClap=false;
        }
        else{
            anim.SetBool("Clap",false);
        }
    }
}
