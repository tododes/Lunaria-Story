using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : Interactible
{
	[SerializeField] private float slowMultiplier;

    protected override void Initialize()
    {
		interactBehaviour = new UnderwaterBehaviour(slowMultiplier);
		collisionBehaviour = new NullCollisionBehaviour ();
    }
}
