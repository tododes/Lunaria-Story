using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAroundAction : IEnemyAction
{
    private Transform transform;
    private bool isRight;
    private float speed;
    private float maxLeft, maxRight;

    public WalkAroundAction(Transform transform, float maxLeft, float maxRight, float speed) {
        this.transform = transform;
        this.speed = speed;
        this.maxLeft = maxLeft;
        this.maxRight = maxRight;
        isRight = true;
    }

    public void doAction() {
        walk();
        turn();
    }

    private void walk() {
        if (isRight) {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }

    private void turn() {
        if (isRight) {
            if (transform.position.x > maxRight) {
                transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
                isRight = false;
            }               
        }
        else {
            if (transform.position.x < maxLeft) {
                transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
                isRight = true;
            }               
        }
    }
}
