using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncrementStageGroupIndexCommand : ICommand
{
    private SelectStageUIGroup group;
    private int increment;

    public IncrementStageGroupIndexCommand(SelectStageUIGroup group, int increment) {
        this.group = group;
        this.increment = increment;
    }

    public void OnExecute()
    {
        
    }

    public void OnStartExecute() {
        group.incrementStageGroupIndex(increment);
    }

    public void OnStopExecute()
    {
        
    }
}
