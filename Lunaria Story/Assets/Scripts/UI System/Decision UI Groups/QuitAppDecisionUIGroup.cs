﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitAppDecisionUIGroup : DecisionUIGroup
{
    [SerializeField]
    private MenuController menuController;

    protected override void InitializeDecisionAction() {
        yesCommand = new QuitAppCommand();
        noCommand = new CloseMenuCommand(menuController);

        registerCommandToButton("Yes Button", yesCommand);
        registerCommandToButton("No Button", noCommand);
    }
}
