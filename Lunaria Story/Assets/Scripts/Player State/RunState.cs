using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunState : IState
{
    private Character character;
    private Rigidbody2D body;
    private float speed;
    private Animator animator;

    private Vector3 originalVelocity;
    private Vector3 velocityAfterTimeScale;

    private float originalAnimationSpeed;

    public RunState(Character character, float speed) {
        this.character = character;
        this.speed = speed;
        body = character.GetComponent<Rigidbody2D>();
        animator = character.GetComponent<Animator>();    
        originalAnimationSpeed = 1f;
    }

    public void doAction() {
        velocityAfterTimeScale = originalVelocity * GameWorld.singleton.getTimeScale();
        //Debug.Log(originalVelocity);
        character.transform.Translate(velocityAfterTimeScale);
        animator.speed = originalAnimationSpeed * GameWorld.singleton.getTimeScale();
    }

    public void stopAction() {
        animator.SetBool("isRun", false);
        animator.SetBool("isIdle", true);
    }

    public void startAction() {
        character.enablePlayerController();
        animator.SetBool("isRun", true);
        animator.SetBool("isIdle", false);
        originalVelocity = Vector3.right * speed * Time.fixedDeltaTime;
    }
}
