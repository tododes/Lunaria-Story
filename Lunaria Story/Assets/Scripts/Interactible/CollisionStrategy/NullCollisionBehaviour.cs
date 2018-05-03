using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullCollisionBehaviour : ICollisionBehaviour
{
    public void OnCollisionEnter(Character character)
    {
        return;
    }

    public void OnCollisionExit(Character character)
    {
        return;
    }

    public void OnCollisionStay(Character character)
    {
        return;
    }
}
