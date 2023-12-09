using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControll : MonoBehaviour
{
    Animator anim;
    
    //sprout 제거 에니메이션 제어변ㄱ수
    public bool Take=false;
    
    //QuestManager
    public GameObject questManager;

    // Start is called before the first frame update
    void Awake()
    {
        anim=GetComponent<Animator>();
        
        //Take
        Take=questManager.GetComponent<QuestManager>().IsTake;

    }

    // Update is called once per frame
    void Update()
    {
        if(Take){
                anim.SetBool("Take",true);
                Take=false;
            }
            else{
                anim.SetBool("Take",false);
            }
    }
}
