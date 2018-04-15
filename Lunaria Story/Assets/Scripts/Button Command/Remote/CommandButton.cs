using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class CommandButton : Button, IPointerDownHandler, IPointerUpHandler {

    private List<ICommand> commands = new List<ICommand>();
    private bool isBeingPressed;

    public override void OnPointerUp(PointerEventData eventData) {
        isBeingPressed = false;

        for (int i = 0; i < commands.Count; i++) {
            commands[i].OnStopExecute();
        }
    }

    public override void OnPointerDown(PointerEventData eventData) {
        isBeingPressed = true;

        for (int i = 0; i < commands.Count; i++) {
            commands[i].OnStartExecute();
        }
    }

    private void OnPointerPress() {
        for (int i = 0; i < commands.Count; i++) {
            commands[i].OnExecute();
        }
    }

    public void registerCommand(ICommand newCommand) {
        commands.Add(newCommand);
    }

    private void Update() {
        if (isBeingPressed) {
            OnPointerPress();
        }
    }
}
