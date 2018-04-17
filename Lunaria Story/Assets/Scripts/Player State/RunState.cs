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

    public RunState(Character character, float speed) {
        this.character = character;
        this.speed = speed;
        body = character.GetComponent<Rigidbody2D>();
        animator = character.GetComponent<Animator>();
    }

    public void doAction() {
        character.transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    public void stopAction() {
        animator.SetBool("isRun", false);
        animator.SetBool("isIdle", true);
    }

    public void startAction() {
        character.enablePlayerController();
        animator.SetBool("isRun", true);
        animator.SetBool("isIdle", false);
    }
}
