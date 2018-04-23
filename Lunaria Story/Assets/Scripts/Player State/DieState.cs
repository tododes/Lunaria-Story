using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieState : IState
{
    private Character character;
    private Animator animator;
    private MenuController menuController;
    private DieUIGroup dieGroup;

    public DieState(Character character) {
        this.character = character;
        animator = character.GetComponent<Animator>();
        menuController = GameObject.Find("Menu Controller").GetComponent<MenuController>();
        dieGroup = GameObject.Find("Die UI Group").GetComponent<DieUIGroup>();
    }

    public void doAction() {
        
    }

    public void startAction() {
        menuController.pushUIGroup(dieGroup);
        animator.SetBool("isDead", true);
        character.disablePlayerController();
    }

    public void stopAction() {

    }
}
