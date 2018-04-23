using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {

    [SerializeField] private MenuUIGroup initialGroup;
    [SerializeField] private Stack<MenuUIGroup> groups = new Stack<MenuUIGroup>();

    void Start() {
        pushUIGroup(initialGroup);
    }

    public void pushUIGroup(MenuUIGroup group) {
        if(groups.Count() > 0)
            groups.Top().hide();
        groups.Add(group);
        groups.Top().display();
    }

    public void popUIGroup() {
        if (groups.Count() > 0) {
            groups.Top().hide();
            groups.Remove();
        }

        groups.Top().display();
    }
}
