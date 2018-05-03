using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageCompleteUIGroup : MenuUIGroup, IRemote, ICharacterObserver
{
    [SerializeField] private MenuController menuController;
    private int currentSceneIndex;
    private WaitForSeconds waitForTwoAndHalfSecond = new WaitForSeconds(2.5f);
    private ICommand changeSceneCommand;

    protected override void InitializeGroup() {
        RectTransform transform = GetComponent<RectTransform>();
        setDisplayBehaviour(new DropBehaviour(rectTransform, 0, 700f, 3f));
        changeSceneCommand = new LoadSceneCommand("Main Menu", this);
        //char sceneLastChar = Application.loadedLevelName[Application.loadedLevelName.Length - 1];
        //currentSceneIndex = (int)sceneLastChar - '0';
        //registerCommandToButton("Next Stage Button", new LoadSceneCommand("Scene " + (currentSceneIndex + 1), this));
        //registerCommandToButton("Exit Button", new LoadSceneCommand("Main Menu", this));


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
        StartCoroutine(delayToMainMenu());
    }

    private IEnumerator delayToMainMenu() {
        yield return waitForTwoAndHalfSecond;
        changeSceneCommand.OnStartExecute();
    }
}
