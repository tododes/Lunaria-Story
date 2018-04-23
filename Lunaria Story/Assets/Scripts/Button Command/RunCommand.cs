using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunCommand : PlayerControlCommand
{
    private float facingAngle;

    public RunCommand(Character character, float facingAngle) : base(character) {
        this.facingAngle = facingAngle;
    }

    protected override void OnExecutePlayerControlCommand() {
        
    }

    protected override void OnStartExecutePlayerControlCommand()
    {
        character.setFacingAngle(facingAngle);
        character.run();
    }

    protected override void OnStopExecutePlayerControlCommand()
    {
        character.doNothing();
    }
}
