using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chasm : Interactible
{
    protected override void Initialize()
    {
        interactBehaviour = new KillingBehaviour();
        collisionBehaviour = new NullCollisionBehaviour();
    }
}
