using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMenuCommand : ICommand
{
    private MainMenuController controller;
    private MenuUIGroup group;

    public ChangeMenuCommand(MainMenuController controller, MenuUIGroup group) {
        this.controller = controller;
        this.group = group;
    }

    public void OnExecute()
    {
        
    }

    public void OnStartExecute()
    {
        controller.pushUIGroup(group);
    }

    public void OnStopExecute()
    {
        
    }
}
