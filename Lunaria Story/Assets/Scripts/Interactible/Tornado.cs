using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tornado : Enemy
{
    [SerializeField]
    private float maxLeft, maxRight, speed;

    protected override void InitializeEnemy() {
        collisionBehaviour = new NullCollisionBehaviour();
        setEnemyAction(new WalkAroundAction(transform, maxLeft, maxRight, speed, 1f));
    }
}
