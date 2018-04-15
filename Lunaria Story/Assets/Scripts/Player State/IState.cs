using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState {
    void startAction();
    void doAction();
    void stopAction();
}
