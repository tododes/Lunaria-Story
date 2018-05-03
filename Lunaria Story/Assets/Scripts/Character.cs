using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Attribute {
    public float runSpeed;
    public float jumpForce;
}

[RequireComponent(typeof(Rigidbody2D), typeof(Animator))]
public class Character : MonoBehaviour {

    [SerializeField] private Attribute attribute;

    private Checkpoint lastCheckpoint;
    private IState currentState;
    private Rigidbody2D body;
    private List<ICharacterObserver> observers = new List<ICharacterObserver>();
    private bool controllable;

    private int jumpCounter;
    
	void Start () {
        idle();
        body = GetComponent<Rigidbody2D>();
        registerObserver(Camera.main.GetComponent<PlayerCamera>());
        registerObserver(GameObject.Find("Stage Complete UI Group").GetComponent<StageCompleteUIGroup>());
        jumpCounter = 1;
	}

	void FixedUpdate () {
        currentState.doAction();
	}

    public void setCurrentState(IState state) {
        if (currentState != null)
            currentState.stopAction();

        currentState = state;
        currentState.startAction();
    }

    protected void OnTriggerEnter2D(Collider2D coll)
    {
        Interactible interactible = coll.GetComponent<Interactible>();
        interactible.OnInteractEnter(this);
    }

    protected void OnTriggerStay2D(Collider2D coll)
    {
        Interactible interactible = coll.GetComponent<Interactible>();
        interactible.OnInteractStay(this);
    }

    protected void OnTriggerExit2D(Collider2D coll)
    {
        Interactible interactible = coll.GetComponent<Interactible>();
        interactible.OnInteractExit(this);
    }

    protected void OnCollisionEnter2D(Collision2D coll)
    {
        Interactible interactible = coll.collider.GetComponent<Interactible>();

        if(interactible)
            interactible.OnStartCollision(this);
    }

    protected void OnCollisionStay2D(Collision2D coll)
    {
        Interactible interactible = coll.collider.GetComponent<Interactible>();

        if (interactible)
            interactible.OnStayCollision(this);
    }

    protected void OnCollisionExit2D(Collision2D coll)
    {
        Interactible interactible = coll.collider.GetComponent<Interactible>();

        if (interactible)
            interactible.OnStopCollision(this);
    }

    public void jump(float powerMultiplier) {
        if (jumpCounter > 0) {
            setCurrentState(new JumpState(this, attribute.jumpForce * powerMultiplier));
            MoveNotificationToObservers();
            jumpCounter--;
        }
    }

    public void bounceJump(Vector3 bounceDirection, float powerMultiplier) {
        setCurrentState(new JumpState(bounceDirection, this, attribute.jumpForce * powerMultiplier));
        MoveNotificationToObservers();
    }

    public void run() {
        setCurrentState(new RunState(this, attribute.runSpeed));
        MoveNotificationToObservers();
    }

    public void idle() {
        setCurrentState(new IdleState(this));
    }

    public void doNothing() {
        setCurrentState(new NullState());
    }

    public void die() {
        DieNotificationToObservers();
        setCurrentState(new DieState(this));
        CheckpointDataLoader.singleton.unsaveCheckpointPosition();
    }

    public void setFacingAngle(float angle) {
        transform.eulerAngles = new Vector3(0, angle, 0);
    }

    public void setRecentlyReachedCheckpoint(Checkpoint lastCheckpoint) {
        this.lastCheckpoint = lastCheckpoint;
    }

    public void registerObserver(ICharacterObserver observer) {
        observers.Add(observer);
    }

    private void DieNotificationToObservers() {
        for (int i = 0; i < observers.Count; i++) {
            observers[i].OnCharacterDie(this);
        }
    }

    private void MoveNotificationToObservers()
    {
        for (int i = 0; i < observers.Count; i++)
        {
            observers[i].OnCharacterMove(this);
        }
    }

    private void DeadEndNotificationToObservers()
    {
        for (int i = 0; i < observers.Count; i++)
        {
            observers[i].OnCharacterMeetDeadEnd(this);
        }
    }

    private void StageCompleteNotificationToObservers() {
        for (int i = 0; i < observers.Count; i++) {
            observers[i].OnStageCompleted(this);
        }
    }

    public void completeStage() {
        StageCompleteNotificationToObservers();
        CheckpointDataLoader.singleton.unsaveCheckpointPosition();
    }

    public void enablePlayerController() {
        controllable = true;
    }

    public void disablePlayerController() {
        controllable = false;
    }

    public bool isControllable() {
        return controllable;
    }

    public void resetJumpCounter() {
        jumpCounter = 1;
    }

	public void modifySpeedWithMultiplier(float speedMultiplier){
		attribute.runSpeed *= speedMultiplier;
	}
}
