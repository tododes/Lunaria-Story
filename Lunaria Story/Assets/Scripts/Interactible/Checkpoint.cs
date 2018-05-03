﻿//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : Interactible {

    [SerializeField] private bool shouldNotifyObservers;
    [SerializeField] private CheckpointData checkpointData;

    private CheckpointBehaviour checkpointBehaviour;

    protected override void Initialize() {
        checkpointBehaviour = new CheckpointBehaviour(this, checkpointData, shouldNotifyObservers);
        interactBehaviour = checkpointBehaviour;
        collisionBehaviour = new NullCollisionBehaviour();

        registerCheckpointObserver(GameObject.Find("Game UI Group").GetComponent<GameUIGroup>());
    }

    public void registerCheckpointObserver(ICheckpointObserver observer) {
        checkpointBehaviour.registerObserver(observer);
    }
}
