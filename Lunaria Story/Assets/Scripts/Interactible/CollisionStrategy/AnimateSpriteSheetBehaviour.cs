using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateSpriteSheetBehaviour : ModifiableCollisionBehaviour
{
    private SpriteSheetAnimation animation;

    public AnimateSpriteSheetBehaviour(SpriteSheetAnimation animation, ICollisionBehaviour otherBehaviour) : base(otherBehaviour)
    {
        this.animation = animation;
    }

    public override void OnCollisionEnter(Character character)
    {
        animation.playAnimationOnce();
        otherBehaviour.OnCollisionEnter(character);
    }

    public override void OnCollisionExit(Character character)
    {
        otherBehaviour.OnCollisionExit(character);
    }

    public override void OnCollisionStay(Character character)
    {
        otherBehaviour.OnCollisionStay(character);
    }
}
