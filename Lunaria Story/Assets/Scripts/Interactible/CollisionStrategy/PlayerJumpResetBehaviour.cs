using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpResetBehaviour : ICollisionBehaviour
{
    public void OnCollisionEnter(Character character)
    {
        character.resetJumpCounter();
    }

    public void OnCollisionExit(Character character)
    {
        
    }

    public void OnCollisionStay(Character character)
    {
        
    }
}
