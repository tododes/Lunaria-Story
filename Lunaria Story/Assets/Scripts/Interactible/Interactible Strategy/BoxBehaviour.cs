using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBehaviour : InteractBehaviour
{
    private Box box;
    private Rigidbody2D body;
    private WaitForSeconds waitOneSecond = new WaitForSeconds(1);
	private bool canDrop;

	public BoxBehaviour(Box box, bool canDrop) {
        this.box = box;
        body = box.GetComponent<Rigidbody2D>();
		this.canDrop = canDrop;
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
		if(canDrop)
        	body.constraints = RigidbodyConstraints2D.None;
    }
}
