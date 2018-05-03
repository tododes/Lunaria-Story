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
    private float turnMultiplier;

    public WalkAroundAction(Transform transform, float maxLeft, float maxRight, float speed, float turnMultiplier) {
        this.transform = transform;
        this.speed = speed;
        this.maxLeft = maxLeft;
        this.maxRight = maxRight;
        this.turnMultiplier = turnMultiplier;
        isRight = true;
    }

    public void doAction() {
        walk();
        turn();
    }

    private void walk() {
        if (isRight) {
            transform.Translate(Vector3.right * speed * GameWorld.singleton.getTimeScale() * Time.deltaTime);
        }
        else {
            transform.Translate(Vector3.left * speed * GameWorld.singleton.getTimeScale() * Time.deltaTime);
        }
    }

    private void turn() {
        if (isRight) {
            if (transform.position.x > maxRight) {
                transform.localScale = new Vector3(turnMultiplier * transform.localScale.x, transform.localScale.y, transform.localScale.z);
                isRight = false;
            }               
        }
        else {
            if (transform.position.x < maxLeft) {
                transform.localScale = new Vector3(turnMultiplier * transform.localScale.x, transform.localScale.y, transform.localScale.z);
                isRight = true;
            }               
        }
    }
}
