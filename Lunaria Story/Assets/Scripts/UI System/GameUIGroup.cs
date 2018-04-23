using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUIGroup : MenuUIGroup, ICheckpointObserver {

    [SerializeField] private CheckpointText checkpointText;

    public void OnCheckpointReached() {
        checkpointText.display();
    }

    protected override void InitializeGroup() {
        checkpointText = GetComponentInChildren<CheckpointText>();
        setDisplayBehaviour(new DropBehaviour(rectTransform, 0f, 600f, 2f));
    }

}
