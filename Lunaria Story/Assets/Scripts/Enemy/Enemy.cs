using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Interactible
{
    protected IEnemyAction enemyAction;

    protected override void Initialize() {
        interactBehaviour = new KillingBehaviour();
        InitializeEnemy();
    }

    protected abstract void InitializeEnemy();

    public void setEnemyAction(IEnemyAction enemyAction) {
        this.enemyAction = enemyAction;
    }

    protected void Update() {
        enemyAction.doAction();
    }
}
