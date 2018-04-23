using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMenuCommand : ICommand
{
    private MenuController controller;
    private MenuUIGroup group;

    public ChangeMenuCommand(MenuController controller, MenuUIGroup group) {
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
