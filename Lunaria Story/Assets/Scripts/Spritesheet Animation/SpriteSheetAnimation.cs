using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSheetAnimation {

    private MonoBehaviour mono;
    private SpriteRenderer renderer;
    private List<Sprite> sprites;
    private WaitForSeconds waitForInterval;
    private float fps;

    public SpriteSheetAnimation(MonoBehaviour mono, Sprite[] sprites, float fps) {
        this.mono = mono;
        renderer = mono.GetComponent<SpriteRenderer>();
        this.sprites = new List<Sprite>(sprites);
        this.fps = fps;
        waitForInterval = new WaitForSeconds(1f / fps);
    }

    public void playAnimationOnce() {
        mono.StartCoroutine(playAnimation());
    }

    public void loopAnimation() {
        mono.StartCoroutine(playLoopAnimation());
    }

    private IEnumerator playAnimation() {
        Debug.Log(sprites.Count);
        for (int i = 0; i < sprites.Count; i++) {
            renderer.sprite = sprites[i];
            yield return waitForInterval;
        }
    }

    private IEnumerator playLoopAnimation() {
        while (true) {
            for (int i = 0; i < sprites.Count; i++) {
                renderer.sprite = sprites[i];
                yield return waitForInterval;
            }
        }
    }
}
