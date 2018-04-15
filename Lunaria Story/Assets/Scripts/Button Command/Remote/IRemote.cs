using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRemote {

    void registerCommandToButton(CommandButton button, ICommand command);
    void registerCommandToButton(string buttonName, ICommand command);
}
