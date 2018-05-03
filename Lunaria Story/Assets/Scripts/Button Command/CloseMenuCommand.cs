using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseMenuCommand : ICommand
{
    private MenuController controller;

    public CloseMenuCommand(MenuController controller) {
        this.controller = controller;
    }

    public void OnExecute()
    {
        
    }

    public void OnStartExecute()
    {
        controller.popUIGroup();
    }

    public void OnStopExecute()
    {
        
    }
}
