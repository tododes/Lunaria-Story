using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingSceneUIGroup : MenuUIGroup
{
    protected override void InitializeGroup() {
        setDisplayBehaviour(new VisibilityBehaviour(transform));
        hide();
    }
}
