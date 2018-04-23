using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageCompleteBehaviour : InteractBehaviour
{
    public void OnStartInteract(Character character) {
        character.completeStage();
    }

    public void OnStayInteract(Character character)
    {
        
    }

    public void OnStopInteract(Character character)
    {
        
    }
}
