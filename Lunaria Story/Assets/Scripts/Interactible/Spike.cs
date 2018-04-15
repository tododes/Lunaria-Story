using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : Interactible {

    protected override void Initialize() {
        interactBehaviour = new KillingBehaviour();
    }

}
