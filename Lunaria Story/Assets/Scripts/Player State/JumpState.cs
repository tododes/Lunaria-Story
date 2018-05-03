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
    private Character character;

    private Vector3 jumpForce;
    private Vector3 jumpForceAfterTimeScale;

    private float originalAnimationSpeed;

    public JumpState(Character character, float force) {
        this.character = character;
        this.force = force;
        body = character.GetComponent<Rigidbody2D>();
        animator = character.GetComponent<Animator>();

        jumpForce = Vector3.up * force;
        originalAnimationSpeed = 1f;
    }

    public JumpState(Vector3 jumpDirection, Character character, float force)
    {
        this.character = character;
        this.force = force;
        body = character.GetComponent<Rigidbody2D>();
        animator = character.GetComponent<Animator>();

        jumpForce = jumpDirection * force;
        originalAnimationSpeed = 1f;
    }

    public void doAction() {
        animator.speed = originalAnimationSpeed * GameWorld.singleton.getTimeScale();
    }

    public void stopAction() {
        isJumping = false;
    }

    public void startAction() {
        animator.SetTrigger("Jump");
        jumpForceAfterTimeScale = jumpForce * GameWorld.singleton.getTimeScale();
        body.AddForce(jumpForceAfterTimeScale);
        isJumping = true;
        character.enablePlayerController();
    }
}
