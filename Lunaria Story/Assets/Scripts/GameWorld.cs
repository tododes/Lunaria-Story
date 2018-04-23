using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWorld : MonoBehaviour {

    [Range(0f, 1f)] private float timeScale;
    [Range(0f, 1f)] private float gravityScale;

    public float getTimeScale() {
        return timeScale;
    }

    public float getGravityScale() {
        return gravityScale;
    }
}
