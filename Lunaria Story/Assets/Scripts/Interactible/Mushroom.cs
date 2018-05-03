using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : Interactible
{
    [SerializeField] private float bounceForce;
    [SerializeField] private Sprite[] sprites;

    private SpriteSheetAnimation spriteSheetAnimation;

    protected override void Initialize()
    {
        spriteSheetAnimation = new SpriteSheetAnimation(this, sprites, 12f);
        collisionBehaviour = new AnimateSpriteSheetBehaviour(spriteSheetAnimation, new TrampolineBehaviour(bounceForce));
    }
}
