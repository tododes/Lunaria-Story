using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillingBehaviour : InteractBehaviour
{
    public void OnStartInteract(Character character){
        character.die();
    }

    public void OnStayInteract(Character character){
       
    }

    public void OnStopInteract(Character character){
        
    }
}
