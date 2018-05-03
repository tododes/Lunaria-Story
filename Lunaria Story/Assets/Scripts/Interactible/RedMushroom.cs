using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedMushroom : Interactible
{
    protected override void Initialize()
    {
        collisionBehaviour = new TrampolineBehaviour(transform.up, 1600f);
    }
}
