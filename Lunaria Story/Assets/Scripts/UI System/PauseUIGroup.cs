using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseUIGroup : MenuUIGroup, IKeyListener, IRemote
{
    private KeyCode keyToTrigger;
    private ICommand keyCommand;
    [SerializeField] private MenuController menuController;
    [SerializeField] private LoadSceneDecisionUIGroup decisionUIGroup;

    public void listen() {
        if (Input.GetKeyDown(keyToTrigger)) {
            keyCommand.OnStartExecute();
        }
    }

    public void registerKey(KeyCode key, ICommand command) {
        keyToTrigger = key;
        keyCommand = command; 
    }

    protected override void InitializeGroup() {
        MenuController controller = GameObject.Find("Menu Controller").GetComponent<MenuController>();
        setDisplayBehaviour(new PauseBehaviour(new DropBehaviour(rectTransform, 0, 500f, 2f), this));
        registerKey(KeyCode.P, new PauseGameCommand(controller, this));
        registerCommandToButton("Resume Button", new UnpauseGameCommand(controller));
        registerCommandToButton("Quit Button", new ChangeMenuCommand(menuController, decisionUIGroup));
    }

    void LateUpdate() {
        listen();
    }

    public void registerCommandToButton(CommandButton button, ICommand command) {
        button.registerCommand(command);
    }

    public void registerCommandToButton(string buttonName, ICommand command) {
        registerCommandToButton(transform.Find(buttonName).GetComponent<CommandButton>(), command);
    }
}
