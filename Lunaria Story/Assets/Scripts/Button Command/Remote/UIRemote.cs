using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIRemote : MonoBehaviour, IRemote {

    [SerializeField] private Character mainCharacter;
    [SerializeField] private MenuController menuController;

    public void registerCommandToButton(string buttonName, ICommand command) {
        transform.Find(buttonName).GetComponent<CommandButton>().registerCommand(command);
    }

    public void registerCommandToButton(CommandButton button, ICommand command) {
        button.registerCommand(command);
    }

    // Use this for initialization
    void Start () {
        registerCommandToButton("LeftButton", new RunCommand(mainCharacter, 180f));
        registerCommandToButton("RightButton", new RunCommand(mainCharacter, 0f));
        registerCommandToButton("JumpButton", new JumpCommand(mainCharacter));
        registerCommandToButton("Pause Button", new PauseGameCommand(menuController, GameObject.Find("Pause UI Group").GetComponent<PauseUIGroup>()));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
