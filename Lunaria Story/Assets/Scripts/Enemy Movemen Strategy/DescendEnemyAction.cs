using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendEnemyAction : IEnemyAction
{
    private Vector3 velocity, originalVelocity;
    private Transform transform;

    public DescendEnemyAction(Transform transform, float minY, float maxY, float speedMultiplier) {
        originalVelocity = new Vector3(0, -1f * (maxY - minY), 0) * speedMultiplier * Time.fixedDeltaTime;
        this.transform = transform;
    }

    public void doAction() {
        velocity = originalVelocity * GameWorld.singleton.getTimeScale();
        transform.Translate(velocity);
    }
}
