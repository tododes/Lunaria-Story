using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMovingSpikeBehaviour : InteractBehaviour
{
    [SerializeField] private MovingSpike movingSpike;

    public TriggerMovingSpikeBehaviour(MovingSpike movingSpike) {
        this.movingSpike = movingSpike;
    }

    public void OnStartInteract(Character character)
    {
        movingSpike.Trigger();
    }

    public void OnStayInteract(Character character)
    {
        
    }

    public void OnStopInteract(Character character)
    {
        
    }
}
