using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUIGroup : MenuUIGroup, ICheckpointObserver, ICharacterObserver {

    [SerializeField] private CheckpointText checkpointText;
    [SerializeField] private DieText dieText;

    public void OnCharacterDie(Character character) {
        dieText.display();
    }

    public void OnCheckpointReached() {
        checkpointText.display();
    }

    protected override void InitializeGroup() {
        checkpointText = GetComponentInChildren<CheckpointText>();
        dieText = GetComponentInChildren<DieText>();
        setDisplayBehaviour(new NullBehaviour());
    }

}
