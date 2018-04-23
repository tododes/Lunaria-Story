using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBehaviour : InteractBehaviour
{
    private Box box;
    private Rigidbody2D body;
    private WaitForSeconds waitOneSecond = new WaitForSeconds(1);

    public BoxBehaviour(Box box) {
        this.box = box;
        body = box.GetComponent<Rigidbody2D>();
    }

    public void OnStartInteract(Character character) {
        box.StartCoroutine(delayToEnableGravity());
    }

    public void OnStayInteract(Character character)
    {
       
    }

    public void OnStopInteract(Character character)
    {
        
    }

    private IEnumerator delayToEnableGravity() {
        yield return waitOneSecond;
        body.constraints = RigidbodyConstraints2D.None;
    }
}
