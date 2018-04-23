using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuUIGroup : MenuUIGroup, IRemote
{
    [SerializeField] private MenuController controller;
    [SerializeField] private QuitAppDecisionUIGroup quitGroup;
    [SerializeField] private float maxY, minY;

    public void registerCommandToButton(string buttonName, ICommand command)
    {
        registerCommandToButton(transform.Find(buttonName).GetComponent<CommandButton>(), command);
    }

    public void registerCommandToButton(CommandButton button, ICommand command)
    {
        button.registerCommand(command);
    }

    protected override void InitializeGroup() {
        setDisplayBehaviour(new DropBehaviour(rectTransform, minY, maxY, 2f));
        registerCommandToButton("Start Game Button", new LoadSceneCommand("Scene", this));
        registerCommandToButton("Select Stage Button", new ChangeMenuCommand(controller, GameObject.Find("Select Stage UI Group").GetComponent<SelectStageUIGroup>()));
        registerCommandToButton("Quit Button", new ChangeMenuCommand(controller, quitGroup));
    }
}
