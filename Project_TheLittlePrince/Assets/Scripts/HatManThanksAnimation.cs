using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatManThanksAnimation : MonoBehaviour
{
    Animator anim;

    public GameObject questManager;
    QuestManager qm;

    bool Thanks=false;
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
        qm=questManager.GetComponent<QuestManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Thanks=qm.IsThank;

        if(Thanks){
            anim.SetBool("Thanks",true);
            qm.IsThank=false;
        }
        else{
            anim.SetBool("Thanks",false);
        }
    }
}
