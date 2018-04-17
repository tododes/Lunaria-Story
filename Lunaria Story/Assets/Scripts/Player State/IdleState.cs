using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IState
{
    private Animator animator;
    private Character character;

    public IdleState(Character character) {
        this.character = character;
        animator = character.GetComponent<Animator>();
    }

    public void doAction() {
        
    }

    public void startAction(){
        animator.SetBool("isIdle", true);
        character.enablePlayerController();
    }

    public void stopAction() {
        
    }
}
