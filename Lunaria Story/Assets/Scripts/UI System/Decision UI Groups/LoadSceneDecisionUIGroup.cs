using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneDecisionUIGroup : DecisionUIGroup
{
    [SerializeField] private MenuController menuController;

    protected override void InitializeDecisionAction() {
        yesCommand = new LoadSceneCommand("Main Menu", this);
        noCommand = new UnpauseGameCommand(menuController);
        registerCommandToButton("Yes Button", yesCommand);
        registerCommandToButton("No Button", noCommand);
    }
}
