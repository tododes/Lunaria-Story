using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBehaviour : IDisplayBehaviour {

    private float minPosY, maxPosY;
    private float currentDestinationY;
    private float velocity;
    private RectTransform transform;
    private Vector3 clampedPosition;

    public DropBehaviour(RectTransform transform, float minPosY, float maxPosY) {
        this.transform = transform;
        this.minPosY = minPosY;
        this.maxPosY = maxPosY;
        velocity = (maxPosY - minPosY) * 2f;
        clampedPosition = Vector3.zero;
        hide();
    }

    public void display() {
        currentDestinationY = minPosY;
    }

    public void hide() {
        currentDestinationY = maxPosY;
    }

    public void tick() {
        if (transform.localPosition.y < currentDestinationY)
            transform.Translate(Vector3.up * velocity * Time.deltaTime);

        if (transform.localPosition.y > currentDestinationY)
            transform.Translate(Vector3.down * velocity * Time.deltaTime);

        clampedPosition.x = transform.localPosition.x;
        clampedPosition.y = Mathf.Clamp(transform.localPosition.y, minPosY, maxPosY);
        clampedPosition.z = transform.localPosition.z;

        transform.localPosition = clampedPosition;
    }

}
