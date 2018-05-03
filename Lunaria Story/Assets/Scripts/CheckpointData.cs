using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointData : ScriptableObject {

    [SerializeField] private Vector3 position;

    private ILoadDataAction loadDataAction;

    public Vector3 getPosition() {
        return position;
    }

    public void setPosition(Checkpoint checkpoint) {
        position = checkpoint.transform.position;
    }

    public void setLoadDataAction(ILoadDataAction loadDataAction)
    {
        this.loadDataAction = loadDataAction;
    }

    public void loadData(Character character) {
        if (loadDataAction != null)
            loadDataAction.loadData(character, this);
    }
}
