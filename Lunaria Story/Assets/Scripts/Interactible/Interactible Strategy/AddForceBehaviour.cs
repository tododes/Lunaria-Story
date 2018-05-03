using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceBehaviour : InteractBehaviour
{
    private Rigidbody2D body;
    private float angle, rad;
    private float sign;

    public AddForceBehaviour(float angle, float sign) {
        this.angle = angle;
        this.sign = sign;
    }

    public void OnStartInteract(Character character) {
        body = character.GetComponent<Rigidbody2D>();
        rad = angle * Mathf.Deg2Rad;
    }

    public void OnStayInteract(Character character)
    {
        body.AddForce(Vector3.right * Mathf.Sin(rad) * sign * 40f);
    }

    public void OnStopInteract(Character character)
    {
        
    }
}
