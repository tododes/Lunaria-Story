using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisibilityBehaviour : IDisplayBehaviour
{
    private Image[] images;
    private Text[] texts;
    private Button[] buttons;

    public VisibilityBehaviour(Transform transform) {
        images = transform.GetComponentsInChildren<Image>();
        texts = transform.GetComponentsInChildren<Text>();
        buttons = transform.GetComponentsInChildren<Button>();
    }

    public void display() {
        for (int i = 0; i < images.Length; i++) {
            images[i].enabled = true;
        }

        for (int i = 0; i < texts.Length; i++) {
            texts[i].enabled = true;
        }

        for (int i = 0; i < buttons.Length; i++) {
            buttons[i].enabled = true;
        }
    }

    public void hide() {
        for (int i = 0; i < images.Length; i++) {
            images[i].enabled = false;
        }

        for (int i = 0; i < texts.Length; i++) {
            texts[i].enabled = false;
        }

        for (int i = 0; i < buttons.Length; i++) {
            buttons[i].enabled = true;
        }
    }

    public void tick()
    {
        
    }
}
