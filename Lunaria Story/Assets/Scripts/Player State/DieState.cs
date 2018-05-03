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

    private float originalAnimationSpeed;

    public DieState(Character character) {
        this.character = character;
        animator = character.GetComponent<Animator>();
        menuController = GameObject.Find("Menu Controller").GetComponent<MenuController>();
        dieGroup = GameObject.Find("Die UI Group").GetComponent<DieUIGroup>();
        originalAnimationSpeed = 1f;
    }

    public void doAction() {
        animator.speed = originalAnimationSpeed * GameWorld.singleton.getTimeScale();
    }

    public void startAction() {
        menuController.pushUIGroup(dieGroup);
        animator.SetBool("isDead", true);
        character.disablePlayerController();
    }

    public void stopAction() {

    }
}
