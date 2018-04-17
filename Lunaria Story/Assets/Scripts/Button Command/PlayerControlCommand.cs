using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerControlCommand : ICommand
{
    protected Character character;

    public PlayerControlCommand(Character character) {
        this.character = character;
    }

    public void OnExecute() {
        if (character.isControllable())
            OnExecutePlayerControlCommand();
    }

    public void OnStartExecute() {
        if (character.isControllable()) {
            OnStartExecutePlayerControlCommand();
        }
    }

    public void OnStopExecute() {
        if (character.isControllable()) {
            OnStopExecutePlayerControlCommand();
        }
    }

    protected abstract void OnExecutePlayerControlCommand();
    protected abstract void OnStartExecutePlayerControlCommand();
    protected abstract void OnStopExecutePlayerControlCommand();
}
