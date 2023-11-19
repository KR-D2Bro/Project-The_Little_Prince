using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;
    public string firstAnimationName="IDLE";
    public string secondAnimationName="Drink";

    // Update is called once per frame
    void Update()
    {
        AnimatorStateInfo currentState=animator.GetCurrentAnimatorStateInfo(0);

        if(currentState.IsName(firstAnimationName))
        {
            
            if(currentState.normalizedTime>=3.0f)
            {
                    animator.Play(secondAnimationName);
            }
        }
    }
}