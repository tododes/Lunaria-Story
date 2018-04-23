using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageGroupSelectionModifier : ModifiableDisplayBehaviour
{
    private List<StageButtonUIGroup> groups;

    public StageGroupSelectionModifier(IDisplayBehaviour otherBehaviour, List<StageButtonUIGroup> groups) : base(otherBehaviour)
    {
        this.groups = groups;
    }

    public override void display()
    {
        otherBehaviour.display();
        groups[0].display();
        for (int i = 1; i < groups.Count; i++) {
            groups[i].hide();
        }
    }

    public override void hide()
    {
        otherBehaviour.hide();
    }

    public override void tick()
    {
        otherBehaviour.tick();
    }
}
