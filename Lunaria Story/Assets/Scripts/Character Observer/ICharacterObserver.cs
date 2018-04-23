using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacterObserver {

    void OnCharacterDie(Character character);
    void OnCharacterMove(Character character);
    void OnCharacterMeetDeadEnd(Character character);
    void OnStageCompleted(Character character);
}
