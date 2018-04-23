using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : Interactible
{
    protected override void Initialize() {
        interactBehaviour = new StageCompleteBehaviour();
    }
}
