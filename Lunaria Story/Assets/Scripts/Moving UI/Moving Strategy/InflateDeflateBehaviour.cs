using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InflateDeflateBehaviour : IDisplayBehaviour
{
    private Vector3 maxSize;
    private Vector3 desiredSize;
    private float sizeMultiplier;
    private Vector3 velocity;
    private RectTransform rectTransform;
    private bool deflateAfterInflate;
    private MonoBehaviour monoCoroutine;

    public InflateDeflateBehaviour(RectTransform rectTransform, Vector3 maxSize, float multiplier, bool deflateAfterInflate) {
        this.maxSize = maxSize;
        this.rectTransform = rectTransform;
        this.deflateAfterInflate = deflateAfterInflate;
        monoCoroutine = rectTransform.GetComponent<MonoBehaviour>();
        velocity = maxSize * multiplier;
        hide();
    }

    public void display() {
        sizeMultiplier = 1f;
        desiredSize = sizeMultiplier * maxSize;

        if (deflateAfterInflate) {
            monoCoroutine.StartCoroutine(hideAfterDisplay());
        }
    }

    public void hide() {
        sizeMultiplier = 0f;
        desiredSize = sizeMultiplier * maxSize;
    }

    public void tick() {
        if (rectTransform.localScale.x < desiredSize.x) {
            rectTransform.localScale = rectTransform.localScale + velocity * Time.deltaTime;
        }

        if (rectTransform.localScale.x > desiredSize.x) {
            rectTransform.localScale = rectTransform.localScale - velocity * Time.deltaTime;
        }

        boundScale();
    }

    private IEnumerator hideAfterDisplay() {
        yield return new WaitForSeconds(2.5f);
        hide();
    }

    private void boundScale() {
        rectTransform.localScale = new Vector3(Mathf.Max(rectTransform.localScale.x, 0f), Mathf.Max(rectTransform.localScale.y, 0f), Mathf.Max(rectTransform.localScale.z, 0f));
    }
}
