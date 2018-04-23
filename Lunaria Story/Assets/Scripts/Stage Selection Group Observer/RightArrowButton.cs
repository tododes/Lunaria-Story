using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightArrowButton : MovingUI, IStageSelectionObserver {

    public void update(SelectStageUIGroup group) {
        if (displayBehaviour == null)
            Initialize();

        if (group.currentIndexReachedMax())
            hide();
        else
            display();
    }

    protected override void Initialize()
    {
        RectTransform transform = GetComponent<RectTransform>();
        setDisplayBehaviour(new VisibilityBehaviour(transform));
    }
}
