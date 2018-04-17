//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : Interactible {

    private CheckpointBehaviour checkpointBehaviour;

    protected override void Initialize() {
        checkpointBehaviour = new CheckpointBehaviour(this);
        interactBehaviour = checkpointBehaviour;

        registerCheckpointObserver(GameObject.Find("UI System").GetComponent<GameUIGroup>());
    }

    public void registerCheckpointObserver(ICheckpointObserver observer) {
        checkpointBehaviour.registerObserver(observer);
    }
}
