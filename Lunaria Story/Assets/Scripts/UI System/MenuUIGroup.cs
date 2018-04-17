using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public abstract class MenuUIGroup : MovingUI
{
    protected RectTransform rectTransform;

    protected override void Initialize() {
        rectTransform = GetComponent<RectTransform>();
        InitializeGroup();
    }

    protected abstract void InitializeGroup();
}
