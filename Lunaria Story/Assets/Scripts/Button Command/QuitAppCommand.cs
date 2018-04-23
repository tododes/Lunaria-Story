using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitAppCommand : ICommand
{
    public void OnExecute() {
        
    }

    public void OnStartExecute() {
        Application.Quit();
    }

    public void OnStopExecute() {
        
    }
}
