using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : IState
{
    private float force;
    private Rigidbody2D body;
    private bool isJumping;
    private Animator animator;

    public JumpState(Character character, float force) {
        this.force = force;
        body = character.GetComponent<Rigidbody2D>();
        animator = character.GetComponent<Animator>();
    }

    public void doAction() {
    
    }

    public void stopAction() {
        //animator.SetBool("isJump", false);
        isJumping = false;
    }

    public void startAction() {
        animator.SetTrigger("Jump");
        body.AddForce(Vector3.up * force);
        isJumping = true;
    }
}
