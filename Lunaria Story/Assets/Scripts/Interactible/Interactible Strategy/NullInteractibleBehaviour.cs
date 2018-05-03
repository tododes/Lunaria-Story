using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullInteractibleBehaviour : InteractBehaviour
{
    public void OnStartInteract(Character character)
    {
		return;
    }

    public void OnStayInteract(Character character)
    {
		return;
    }

    public void OnStopInteract(Character character)
    {
		return;
    }
}
