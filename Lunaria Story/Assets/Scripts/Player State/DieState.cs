using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieState : IState
{
    private Animator animator;

    public DieState(Character character) {
        animator = character.GetComponent<Animator>();
    }

    public void doAction() {
        
    }

    public void startAction()
    {
        
    }

    public void stopAction() {

    }
}
