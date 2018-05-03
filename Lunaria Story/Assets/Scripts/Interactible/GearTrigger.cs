using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearTrigger : Interactible
{
    [SerializeField] private Gear gear;

    protected override void Initialize()
    {
        interactBehaviour = new GearTriggerBehaviour(gear);
    }
}
