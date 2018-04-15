using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICommand {
    void OnStartExecute();
    void OnExecute();
    void OnStopExecute();
}
