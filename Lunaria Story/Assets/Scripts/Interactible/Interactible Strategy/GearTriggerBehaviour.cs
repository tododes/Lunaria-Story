using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearTriggerBehaviour : InteractBehaviour
{
    private Gear gear;

    public GearTriggerBehaviour(Gear gear) {
        this.gear = gear;
    }

    public void OnStartInteract(Character character)
    {
        gear.setEnablePhysics(true);
    }

    public void OnStayInteract(Character character)
    {
        
    }

    public void OnStopInteract(Character character)
    {
        
    }
}
