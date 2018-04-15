using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointBehaviour : InteractBehaviour
{
    private Checkpoint checkpoint;
    private List<ICheckpointObserver> observers = new List<ICheckpointObserver>();

    public CheckpointBehaviour(Checkpoint checkpoint) {
        this.checkpoint = checkpoint;
    }

    public void OnStartInteract(Character character) {
        character.setRecentlyReachedCheckpoint(checkpoint);
        notifyAllObservers();
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
