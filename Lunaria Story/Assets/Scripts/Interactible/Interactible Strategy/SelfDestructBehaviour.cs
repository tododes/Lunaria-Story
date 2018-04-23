using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestructBehaviour : ModifiableInteractBehaviour
{
    private GameObject gameObject;

    public SelfDestructBehaviour(InteractBehaviour otherBehaviour, GameObject gameObject) : base(otherBehaviour) {
        this.gameObject = gameObject;
    }

    public override void OnStartInteract(Character character)
    {
        otherBehaviour.OnStartInteract(character);
        UnityEngine.Object.Destroy(gameObject);
    }

    public override void OnStayInteract(Character character)
    {
        otherBehaviour.OnStayInteract(character);
    }

    public override void OnStopInteract(Character character)
    {
        otherBehaviour.OnStopInteract(character);
    }
}
