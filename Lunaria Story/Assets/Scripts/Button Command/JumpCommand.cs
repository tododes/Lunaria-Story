using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCommand : PlayerControlCommand
{

    public JumpCommand(Character character) : base(character) {

    }

    protected override void OnExecutePlayerControlCommand()
    {
       
    }

    protected override void OnStartExecutePlayerControlCommand()
    {
        character.jump(1f);
    }

    protected override void OnStopExecutePlayerControlCommand()
    {
        
    }
}
