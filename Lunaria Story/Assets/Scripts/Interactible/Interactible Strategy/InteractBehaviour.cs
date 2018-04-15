using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface InteractBehaviour {
    void OnStartInteract(Character character);
    void OnStayInteract(Character character);
    void OnStopInteract(Character character);
}
