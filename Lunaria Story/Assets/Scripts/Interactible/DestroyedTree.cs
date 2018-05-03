using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyedTree : Interactible
{
    protected override void Initialize()
    {
        collisionBehaviour = new PlayerJumpResetBehaviour();
    }
}
