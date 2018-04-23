using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Box : Interactible, IFallGroundAction
{
    private Rigidbody2D body;

    public void OnTouchGround() {
        if(body.velocity.y >= 5f)
            Destroy(gameObject);
    }

    protected override void Initialize()
    {
        body = GetComponent<Rigidbody2D>();
        interactBehaviour = new BoxBehaviour(this);
    }
}
