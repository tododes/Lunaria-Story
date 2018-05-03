using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : Enemy
{
    [SerializeField]
    private float maxLeft, maxRight, speed;

    protected override void InitializeEnemy()
    {
        setEnemyAction(new SinudialMoveAction(new WalkAroundAction(transform, maxLeft, maxRight, speed, -1f), transform));
    }
}
