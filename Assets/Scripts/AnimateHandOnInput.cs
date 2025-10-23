using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    // Input action for trigger
    public InputActionProperty pinchAnimationAction;

    // Input action for grip
    public InputActionProperty gripAnimationAction;

    // Animator controlling the hand model
    public Animator handAnimator;

    // Update is called once per frame
    void Update()
    {
        // Read the trigger input value
        float triggerValue = pinchAnimationAction.action.ReadValue<float>();
        // Set the "Trigger" parameter in the Animator
        handAnimator.SetFloat("Trigger", triggerValue);

        // Read the grip input value
        float gripValue = gripAnimationAction.action.ReadValue<float>();
        // Set the "Grip" parameter in the Animator 
        handAnimator.SetFloat("Grip", gripValue);
    }
}
