using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinudialMoveAction : ModifiableEnemyAction
{
    private Transform transform;
    private float timer;
    private Vector3 desiredPosition;

    public SinudialMoveAction(IEnemyAction otherAction, Transform transform) : base(otherAction) {
        this.transform = transform;
    }

    public override void doAction() {
        otherAction.doAction();

        timer += Time.deltaTime * 5f;

        desiredPosition.x = transform.position.x;
        desiredPosition.z = transform.position.z;
        desiredPosition.y = transform.position.y + Mathf.Sin(timer) * 0.1f;

        transform.position = desiredPosition;
    }
}
