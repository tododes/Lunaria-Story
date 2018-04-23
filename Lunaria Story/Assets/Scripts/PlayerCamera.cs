using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour, ICharacterObserver
{
    [SerializeField] private Vector3 desiredPosition;
    private float offsetX;
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
        offsetX = transform.position.x - character.transform.position.x;
        this.character = character;     
    }

    void Update() {
        if (character) {
            desiredPosition.x = character.transform.position.x + offsetX;
            desiredPosition.y = transform.position.y;
            desiredPosition.z = transform.position.z;
            transform.position = desiredPosition;
        }

    }

    public void OnStageCompleted(Character character)
    {
        
    }
}
