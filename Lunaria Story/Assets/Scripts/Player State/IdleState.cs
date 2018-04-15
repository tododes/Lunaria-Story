using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IState
{
    private Animator animator;

    public IdleState(Character character) {
        animator = character.GetComponent<Animator>();
    }

    public void doAction() {
        
    }

    public void startAction(){
        animator.SetBool("isIdle", true);
    }

    public void stopAction() {
        
    }
}
