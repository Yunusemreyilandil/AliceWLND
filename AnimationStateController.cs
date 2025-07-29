using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
     Animator animator;
    int isWalkingHash;
    int isRunningHash;
    void Start()
    {
     animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
    }

    void Update()
    {
        bool isRunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        bool forwardPressed = Input.GetKey(KeyCode.W);
        bool runPressed = Input.GetKey(KeyCode.LeftShift);
        if (!isWalking && forwardPressed)
        {
            animator.SetBool(isWalkingHash ,true);
        }
        if(isWalking && !forwardPressed)
        {
            animator.SetBool(isWalkingHash, false);   
        }
        if (!isRunning && (forwardPressed && runPressed))
        {   
            animator.SetBool(isRunningHash, true);
        }
        if (isRunning &&(!forwardPressed || !runPressed))
        {
            animator.SetBool(isRunningHash , false);    
        }
    }
}
