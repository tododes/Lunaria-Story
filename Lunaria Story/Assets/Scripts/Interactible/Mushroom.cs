using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : Interactible
{
    protected override void Initialize()
    {
        interactBehaviour = new TrampolineBehaviour();
    }
}
