using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class ScriptableObjectGenerator {

#if UNITY_EDITOR
    [MenuItem("Assets/Create/Checkpoint Data")]
    public static void createCheckpointData() {
        CheckpointData data = ScriptableObject.CreateInstance<CheckpointData>();
        AssetDatabase.CreateAsset(data, "Assets/Scriptable Objects/Checkpoint Data.asset");
        AssetDatabase.SaveAssets();
    } 
#endif
}
