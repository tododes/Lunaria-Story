using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnpauseGameCommandModifier : ModifiableCommand
{
    public UnpauseGameCommandModifier(ICommand otherCommand) : base(otherCommand)
    {
    }

    public override void OnExecute() {
        otherCommand.OnExecute();
    }

    public override void OnStartExecute() {
        GameWorld.singleton.unfreeze();
        otherCommand.OnStartExecute();
    }

    public override void OnStopExecute() {
        otherCommand.OnStopExecute();
    }
}
