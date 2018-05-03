using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear : Enemy
{
    private Rigidbody2D body;

    protected override void InitializeEnemy() {
        body = GetComponent<Rigidbody2D>();
        setEnemyAction(new NullEnemyAction());
        collisionBehaviour = new NullCollisionBehaviour();
    }

    public void setEnablePhysics(bool enable) {
        body.simulated = enable;
    }
}
