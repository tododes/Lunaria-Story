using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCommand : ICommand
{
    private Character character;

    public JumpCommand(Character character) {
        this.character = character;
    }

    public void OnExecute()
    {
       
    }

    public void OnStartExecute()
    {
        character.jump();
    }

    public void OnStopExecute()
    {
        
    }
}
