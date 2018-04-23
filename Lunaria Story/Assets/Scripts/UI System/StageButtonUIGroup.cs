using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageButtonUIGroup : MenuUIGroup
{
    [SerializeField] private int minStageNumber;
    [SerializeField] private int maxStageNumber;

    private CommandButton[] commandButtons;

    protected override void InitializeGroup() {
        setDisplayBehaviour(new VisibilityBehaviour(transform));
        commandButtons = GetComponentsInChildren<CommandButton>();
        mapCommandButtons();
    }

    private void mapCommandButtons() {
        int current = minStageNumber;
        int i = 0;

        while (current <= maxStageNumber) {
            commandButtons[i].registerCommand(new LoadSceneCommand("Scene " + current, this));
            i++;
            current++;
        }
    }
}
