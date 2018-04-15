using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunCommand : ICommand
{
    private Character character;
    private float facingAngle;

    public RunCommand(Character character, float facingAngle) {
        this.character = character;
        this.facingAngle = facingAngle;
    }

    public void OnExecute(){
        
    }

    public void OnStartExecute(){
        character.setFacingAngle(facingAngle);
        character.run();
    }

    public void OnStopExecute(){
        character.doNothing();
    }
}
