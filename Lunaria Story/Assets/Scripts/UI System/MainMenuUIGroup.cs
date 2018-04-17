using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuUIGroup : MenuUIGroup, IRemote
{
    public void registerCommandToButton(string buttonName, ICommand command)
    {
        registerCommandToButton(transform.Find(buttonName).GetComponent<CommandButton>(), command);
    }

    public void registerCommandToButton(CommandButton button, ICommand command)
    {
        button.registerCommand(command);
    }

    protected override void InitializeGroup() {
        setDisplayBehaviour(new DropBehaviour(rectTransform, 0f, 600f));

        registerCommandToButton(
            "Go To Option Button", 
            new ChangeMenuCommand(
                GameObject.Find("Main Menu Controller").GetComponent<MainMenuController>(), 
                GameObject.Find("Option UI Group").GetComponent<OptionUIGroup>()
            )
        ) ;
    }
}
