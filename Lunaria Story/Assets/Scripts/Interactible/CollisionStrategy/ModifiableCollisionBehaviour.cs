using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ModifiableCollisionBehaviour : ICollisionBehaviour
{
    protected ICollisionBehaviour otherBehaviour;

    public ModifiableCollisionBehaviour(ICollisionBehaviour otherBehaviour) {
        this.otherBehaviour = otherBehaviour;
    }

    public abstract void OnCollisionEnter(Character character);
    public abstract void OnCollisionExit(Character character);
    public abstract void OnCollisionStay(Character character);
}
