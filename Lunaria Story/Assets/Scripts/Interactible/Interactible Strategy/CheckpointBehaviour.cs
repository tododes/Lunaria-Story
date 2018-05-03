using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointBehaviour : InteractBehaviour
{
    private Checkpoint checkpoint;
    private List<ICheckpointObserver> observers = new List<ICheckpointObserver>();
    private bool stepped;
    private bool shouldNotifyObservers;
    private CheckpointData data;

    public CheckpointBehaviour(Checkpoint checkpoint, CheckpointData data, bool shouldNotifyObservers) {
        this.checkpoint = checkpoint;
        this.shouldNotifyObservers = shouldNotifyObservers;
        this.data = data;
     
    }

    public void OnStartInteract(Character character) {
        if (!stepped) {
            character.setRecentlyReachedCheckpoint(checkpoint);

            if (shouldNotifyObservers)
                notifyAllObservers();

            data.setPosition(checkpoint);

            stepped = true;
        }
    }

    public void OnStayInteract(Character character) {
        
    }

    public void OnStopInteract(Character character) {
        
    }

    public void registerObserver(ICheckpointObserver observer) {
        observers.Add(observer);
    }

    private void notifyAllObservers() {
        for (int i = 0; i < observers.Count; i++) {
            observers[i].OnCheckpointReached();
        }
    }

}
