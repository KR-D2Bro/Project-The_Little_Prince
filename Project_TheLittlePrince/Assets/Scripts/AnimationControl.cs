using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    Animator anim;

    public GameObject questManager;
    QuestManager qm;
    bool Take;
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
        qm=questManager.GetComponent<QuestManager>();
        
        //Take=questManager.GetComponent<QuestManager>().IsTake;
    }

    // Update is called once per frame
    void Update()
    {
        Take=qm.IsTake;

        if(Take){
            anim.SetBool("Take",true);
            qm.IsTake=false;
        }
        else{
            anim.SetBool("Take",false);
        }
    }
}
