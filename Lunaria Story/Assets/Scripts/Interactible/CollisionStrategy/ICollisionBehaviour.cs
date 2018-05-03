using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICollisionBehaviour {

    void OnCollisionEnter(Character character);
    void OnCollisionStay(Character character);
    void OnCollisionExit(Character character);
}
