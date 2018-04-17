﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointText : MovingUI {

    [SerializeField] private float inflateSpeedMultiplier;

    protected override void Initialize()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        setDisplayBehaviour(new InflateDeflateBehaviour(rectTransform, Vector3.one, inflateSpeedMultiplier, true));
    }
}
