using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseBehaviour : ModifiableDisplayBehaviour
{
    public PauseBehaviour(IDisplayBehaviour otherBehaviour, PauseUIGroup pauseGroup) : base(otherBehaviour) {

    }

    public override void display() {
        otherBehaviour.display();
    }

    public override void hide() {
        otherBehaviour.hide();
    }

    public override void tick() {
        otherBehaviour.tick();
    }

}
