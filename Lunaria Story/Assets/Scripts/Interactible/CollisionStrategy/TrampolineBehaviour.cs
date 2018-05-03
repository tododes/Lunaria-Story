using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineBehaviour : ICollisionBehaviour
{
    private Rigidbody2D body;
    private Vector3 jumpDirection;
    private float force;

    public TrampolineBehaviour(float force) {
        this.force = force;
        jumpDirection = Vector3.up;
    }

    public TrampolineBehaviour(Vector3 jumpDirection, float force) {
        this.force = force;
        this.jumpDirection = jumpDirection;
    }

    public void OnCollisionEnter(Character character) {
        character.bounceJump(jumpDirection, 2f);
    }

    public void OnCollisionExit(Character character) {
        
    }

    public void OnCollisionStay(Character character) {
        
    }
}
