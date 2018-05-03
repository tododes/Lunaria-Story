using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSpike : Enemy
{
    [SerializeField] private float minX, maxX;
    [SerializeField] private float minY, maxY;
    [SerializeField] private bool changed;

    protected override void InitializeEnemy() {
        setEnemyAction(new NullEnemyAction());
    }

    private void FixedUpdate() {
        if (transform.position.y <= minY && !changed) {
            setEnemyAction(new WalkAroundAction(transform, minX, maxX, 3f, 1f));
            changed = true;
        }
            
    }

    public void Trigger() {
        setEnemyAction(new DescendEnemyAction(transform, minY, maxY, 3f));
    }
}
