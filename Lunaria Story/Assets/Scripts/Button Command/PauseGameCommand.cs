using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGameCommand : ICommand
{
    private MenuController controller;
    private PauseUIGroup group;

    public PauseGameCommand(MenuController controller, PauseUIGroup group) {
        this.controller = controller;
        this.group = group;
    }

    public void OnExecute() {
        
    }

    public void OnStartExecute() {
        controller.pushUIGroup(group);
    }

    public void OnStopExecute() {
        
    }
}
