using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneCommand : ICommand
{
    private string scene;
    private LoadingSceneUIGroup group;
    private MonoBehaviour mono;
    private MenuController controller;
    private WaitForSeconds oneSecond = new WaitForSeconds(1);

    public LoadSceneCommand(string scene, MonoBehaviour mono) {
        this.mono = mono;
        this.scene = scene;
        group = GameObject.Find("Load Scene UI Group").GetComponent<LoadingSceneUIGroup>();
        controller = GameObject.Find("Menu Controller").GetComponent<MenuController>();
    }

    public void OnExecute()
    {
        
    }

    public void OnStartExecute() {
        controller.pushUIGroup(group);
        mono.StartCoroutine(load());
    }

    public void OnStopExecute()
    {
        
    }

    private IEnumerator load() {
        yield return oneSecond;
        SceneManager.LoadScene(scene);
    }
}
