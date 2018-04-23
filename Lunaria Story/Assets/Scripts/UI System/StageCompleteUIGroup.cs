using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageCompleteUIGroup : MenuUIGroup, IRemote, ICharacterObserver
{
    [SerializeField] private MenuController menuController;
    private int currentSceneIndex;

    protected override void InitializeGroup() {
        RectTransform transform = GetComponent<RectTransform>();
        setDisplayBehaviour(new DropBehaviour(rectTransform, 0, 700f, 3f));
        char sceneLastChar = Application.loadedLevelName[Application.loadedLevelName.Length - 1];
        currentSceneIndex = (int)sceneLastChar - '0';
        registerCommandToButton("Next Stage Button", new LoadSceneCommand("Scene " + currentSceneIndex, this));
        registerCommandToButton("Exit Button", new LoadSceneCommand("Main Menu", this));
    }

    public void registerCommandToButton(string buttonName, ICommand command)
    {
        registerCommandToButton(transform.Find(buttonName).GetComponent<CommandButton>(), command);
    }

    public void registerCommandToButton(CommandButton button, ICommand command)
    {
        button.registerCommand(command);
    }

    public void OnCharacterDie(Character character)
    {
       
    }

    public void OnCharacterMove(Character character)
    {
        
    }

    public void OnCharacterMeetDeadEnd(Character character)
    {
        
    }

    public void OnStageCompleted(Character character) {
        menuController.pushUIGroup(this);
    }
}
