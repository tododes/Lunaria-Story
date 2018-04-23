using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectStageGroupCommand : ICommand
{
    private SelectStageUIGroup selectStageGroup;

    public void OnExecute() {
       
    }

    public void OnStartExecute() {
        selectStageGroup.display();
    }

    public void OnStopExecute() {
       
    }
}
