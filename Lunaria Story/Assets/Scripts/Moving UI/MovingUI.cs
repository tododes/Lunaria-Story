using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MovingUI : MonoBehaviour {

    protected IDisplayBehaviour displayBehaviour;

    // Use this for initialization
    protected void Start () {
        Initialize();
	}

    // Update is called once per frame
    protected void Update () {
        displayBehaviour.tick();
	}

    public void setDisplayBehaviour(IDisplayBehaviour displayBehaviour) {
        this.displayBehaviour = displayBehaviour;
    }

    protected abstract void Initialize();

    public void display() {
        displayBehaviour.display();
    }

    public void hide() {
        displayBehaviour.hide();
    }
}
