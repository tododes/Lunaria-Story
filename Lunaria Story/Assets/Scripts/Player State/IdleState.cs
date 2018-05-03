using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IState
{
    private Animator animator;
    private Character character;
    private float originalAnimationSpeed;

    public IdleState(Character character) {
        this.character = character;
        animator = character.GetComponent<Animator>();
        originalAnimationSpeed = 1f;
    }

    public void doAction() {
        animator.speed = originalAnimationSpeed * GameWorld.singleton.getTimeScale();
    }

    public void startAction(){
        animator.SetBool("isIdle", true);
        character.enablePlayerController();
    }

    public void stopAction() {
        
    }
}
