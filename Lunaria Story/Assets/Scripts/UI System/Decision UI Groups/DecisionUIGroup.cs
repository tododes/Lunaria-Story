using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DecisionUIGroup : MenuUIGroup, IRemote
{
    protected ICommand yesCommand;
    protected ICommand noCommand;

    public void registerCommandToButton(string buttonName, ICommand command)
    {
        registerCommandToButton(transform.Find(buttonName).GetComponent<CommandButton>(), command);
    }

    public void registerCommandToButton(CommandButton button, ICommand command)
    {
        button.registerCommand(command);
    }

    protected override void InitializeGroup() {
        RectTransform transform = GetComponent<RectTransform>();
        setDisplayBehaviour(new DropBehaviour(transform, 0f, 600f, 3f));
        InitializeDecisionAction();
    }

    protected abstract void InitializeDecisionAction();
}
