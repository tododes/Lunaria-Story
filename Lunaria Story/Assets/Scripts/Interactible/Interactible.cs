using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactible : MonoBehaviour {

    protected InteractBehaviour interactBehaviour;
    protected ICollisionBehaviour collisionBehaviour;

    protected abstract void Initialize();

    protected void Start() {
        Initialize();
    }

    public void OnInteractEnter(Character character) {
        interactBehaviour.OnStartInteract(character);
    }

    public void OnInteractStay(Character character) {
        interactBehaviour.OnStayInteract(character);
    }

    public void OnInteractExit(Character character) {
        interactBehaviour.OnStopInteract(character);
    }

    public void OnStartCollision(Character character){
        collisionBehaviour.OnCollisionEnter(character);
    }

    public void OnStayCollision(Character character){
        collisionBehaviour.OnCollisionStay(character);
    }

    public void OnStopCollision(Character character){
        collisionBehaviour.OnCollisionExit(character);
    }
}
