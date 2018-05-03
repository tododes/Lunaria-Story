using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWorld : MonoBehaviour {

    public static GameWorld singleton { get; private set; }

    [SerializeField, Range(0f, 1f)] private float timeScale;
    [SerializeField, Range(0f, 1f)] private float gravityScale;

    void Awake() {
        singleton = this;
    }

    public float getTimeScale() {
        return timeScale;
    }

    public float getGravityScale() {
        return gravityScale;
    }

    public void freeze() {
        timeScale = 0f;
    }

    public void unfreeze() {
        timeScale = 1f;
    }
}
