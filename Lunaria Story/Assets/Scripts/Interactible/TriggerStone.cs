using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerStone : Interactible
{
    [SerializeField] private MovingSpike movingSpike;

    protected override void Initialize() {
        interactBehaviour = new TriggerMovingSpikeBehaviour(movingSpike);
    }
}
