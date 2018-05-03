using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointDataLoader : MonoBehaviour {

    public static CheckpointDataLoader singleton { get; private set; }

    [SerializeField] private Character character;
    [SerializeField] private CheckpointData data;

    void Awake() {
        singleton = this;
    }

    void Start() {
        data.loadData(character);
    }

    void Update() {

    }

    public void saveCheckpointPosition() {
        data.setLoadDataAction(new CheckpointPlacementAction());
    }

    public void unsaveCheckpointPosition()
    {
        data.setLoadDataAction(new NullSaveAction());
    }
}
