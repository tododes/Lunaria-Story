using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieUIGroup : MenuUIGroup
{
    protected override void InitializeGroup()
    {
        setDisplayBehaviour(new DropBehaviour(rectTransform, 0f, 1600f, 1f));
    }
}
