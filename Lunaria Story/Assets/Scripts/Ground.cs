using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : Interactible {


    void OnCollisionEnter2D(Collision2D collision) {
        IFallGroundAction action = (IFallGroundAction) collision.collider.GetComponent(typeof(IFallGroundAction));
        if (action != null) {
            action.OnTouchGround();
        }
    }

    protected override void Initialize() {        
        interactBehaviour = new AddForceBehaviour(transform.eulerAngles.z, Mathf.Sign(transform.eulerAngles.z));
        collisionBehaviour = new PlayerJumpResetBehaviour();
    }
}
