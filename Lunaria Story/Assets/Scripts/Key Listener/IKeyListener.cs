using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IKeyListener {
    void registerKey(KeyCode key, ICommand command);
    void listen();
}
