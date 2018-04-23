using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineBehaviour : InteractBehaviour
{
    private Rigidbody2D body;

    public void OnStartInteract(Character character) {
        body = character.GetComponent<Rigidbody2D>();
        body.AddForce(Vector3.up * 800f);
    }

    public void OnStayInteract(Character character)
    {
        
    }

    public void OnStopInteract(Character character)
    {
        
    }
}
