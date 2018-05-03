using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullSaveAction : ILoadDataAction
{
    public void loadData(Character character, CheckpointData data) {
        return;
    }

}
