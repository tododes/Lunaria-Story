using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullState : IState
{
    public void doAction() {
        return;
    }

    public void startAction() {
        return;
    }

    public void stopAction() {
        return;
    }
}
