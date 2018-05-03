using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILoadDataAction {
    void loadData(Character character, CheckpointData data);
}
