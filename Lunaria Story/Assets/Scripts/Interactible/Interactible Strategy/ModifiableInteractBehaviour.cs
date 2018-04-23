using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ModifiableInteractBehaviour : InteractBehaviour
{
    protected InteractBehaviour otherBehaviour;

    public ModifiableInteractBehaviour(InteractBehaviour otherBehaviour) {
        this.otherBehaviour = otherBehaviour;
    }

    public abstract void OnStartInteract(Character character);
    public abstract void OnStayInteract(Character character);
    public abstract void OnStopInteract(Character character);
   
}
