using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ModifiableCommand : ICommand
{
    protected ICommand otherCommand;

    public ModifiableCommand(ICommand otherCommand) {
        this.otherCommand = otherCommand;
    }

    public abstract void OnExecute();
    public abstract void OnStartExecute();
    public abstract void OnStopExecute();
}
