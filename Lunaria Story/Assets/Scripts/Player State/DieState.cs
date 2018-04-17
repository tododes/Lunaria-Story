using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieState : IState
{
    private Character character;
    private Animator animator;

    public DieState(Character character) {
        this.character = character;
        animator = character.GetComponent<Animator>();
    }

    public void doAction() {
        
    }

    public void startAction() {
        Handheld.Vibrate();
        animator.SetBool("isDead", true);
        character.disablePlayerController();
    }

    public void stopAction() {

    }
}
