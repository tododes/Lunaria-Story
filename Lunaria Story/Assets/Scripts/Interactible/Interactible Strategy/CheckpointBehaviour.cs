using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointBehaviour : InteractBehaviour
{
    private Checkpoint checkpoint;
    private List<ICheckpointObserver> observers = new List<ICheckpointObserver>();
    private bool stepped;

    public CheckpointBehaviour(Checkpoint checkpoint) {
        this.checkpoint = checkpoint;
    }

    public void OnStartInteract(Character character) {
        if (!stepped) {
            character.setRecentlyReachedCheckpoint(checkpoint);
            notifyAllObservers();
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
