using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalEnemy : Enemy
{
    [SerializeField]
    private float maxLeft, maxRight, speed;

    protected override void InitializeEnemy()
    {
        setEnemyAction(new WalkAroundAction(transform, maxLeft, maxRight, speed));
    }

    protected void Update() {
        enemyAction.doAction();
    }
}
