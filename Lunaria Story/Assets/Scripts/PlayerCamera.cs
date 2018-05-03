using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour, ICharacterObserver
{
    [SerializeField] private float minX, maxX;
    [SerializeField] private Vector3 desiredPosition;
    private Character character;

    void Start() {
        desiredPosition = Vector3.zero;
    }

    public void OnCharacterDie(Character character)
    {
       
    }

    public void OnCharacterMeetDeadEnd(Character character)
    {
        
    }

    public void OnCharacterMove(Character character) {
        this.character = character;
    }

    void Update() {
        if (character) {
            desiredPosition.x = character.transform.position.x;
            desiredPosition.y = transform.position.y;
            desiredPosition.z = transform.position.z;

            desiredPosition.x = Mathf.Clamp(desiredPosition.x, minX, maxX);
            transform.position = desiredPosition;
        }

    }

    public void OnStageCompleted(Character character)
    {
        
    }
}
