using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : Interactible
{
    [SerializeField] private float speed;

    protected override void Initialize() {
        interactBehaviour = new SelfDestructBehaviour(new KillingBehaviour(), gameObject);
    }

    void Update() {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
