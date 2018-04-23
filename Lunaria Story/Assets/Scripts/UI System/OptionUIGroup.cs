using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionUIGroup : MenuUIGroup
{
    protected override void InitializeGroup()
    {
        setDisplayBehaviour(new DropBehaviour(rectTransform, 0f, 600f, 2f));
    }
}
