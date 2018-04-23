using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleOnHideDisplayModifier : ModifiableDisplayBehaviour
{
    private VisibilityBehaviour visibilityBehaviour;

    public InvisibleOnHideDisplayModifier(IDisplayBehaviour otherBehaviour, Transform transform) : base(otherBehaviour) {
        visibilityBehaviour = new VisibilityBehaviour(transform);
    }

    public override void display() {
        visibilityBehaviour.display();
        otherBehaviour.display();
    }

    public override void hide() {
        otherBehaviour.hide();
        visibilityBehaviour.hide();
    }

    public override void tick() {
        otherBehaviour.tick();
    }
}
