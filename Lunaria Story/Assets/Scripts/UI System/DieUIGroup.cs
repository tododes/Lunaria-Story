using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieUIGroup : MenuUIGroup, IRemote
{
    public void registerCommandToButton(string buttonName, ICommand command) {
        transform.Find(buttonName).GetComponent<CommandButton>().registerCommand(command);
    }

    public void registerCommandToButton(CommandButton button, ICommand command) {
        button.registerCommand(command);
    }

    protected override void InitializeGroup() {
        setDisplayBehaviour(new DropBehaviour(rectTransform, 0f, 1600f, 1f));
        registerCommandToButton("Yes Retry Button", new LoadSceneCommand(Application.loadedLevelName, this));
        registerCommandToButton("No Retry Button", new LoadSceneCommand("Main Menu", this));
    }
}
