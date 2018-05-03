using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointPlacementAction : ILoadDataAction
{


    public void loadData(Character character, CheckpointData data) {
        Camera cam = Camera.main;
        Vector3 offset = cam.transform.position - character.transform.position;

        character.transform.position = data.getPosition();
        cam.transform.position = new Vector3(character.transform.position.x + offset.x, cam.transform.position.y, cam.transform.position.z);
    }
}
