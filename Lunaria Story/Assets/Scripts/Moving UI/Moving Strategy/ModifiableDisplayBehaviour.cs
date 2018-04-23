using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ModifiableDisplayBehaviour : IDisplayBehaviour {

    protected IDisplayBehaviour otherBehaviour;

    public ModifiableDisplayBehaviour(IDisplayBehaviour otherBehaviour) {
        this.otherBehaviour = otherBehaviour;
    }

    public abstract void display();
    public abstract void hide();
    public abstract void tick();

}
