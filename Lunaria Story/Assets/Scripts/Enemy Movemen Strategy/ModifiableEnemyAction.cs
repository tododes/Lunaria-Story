using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ModifiableEnemyAction : IEnemyAction
{
    protected IEnemyAction otherAction;

    public ModifiableEnemyAction(IEnemyAction otherAction) {
        this.otherAction = otherAction;
    }

    public abstract void doAction();
}
