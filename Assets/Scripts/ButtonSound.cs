using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonSound : MonoBehaviour
{
    private XRBaseInteractable interactable; // XR interactable component ref

    // Audio variables
    public AudioSource source;
    public AudioClip clip;
    private bool hasGrabbedOnce = false; // Bool variable (flag)

    void Awake()
    {
        // Get the XRBaseInteractable component from the GameObject
        interactable = GetComponent<XRBaseInteractable>();

        // Add a listener for a selectEntered event
        interactable.selectEntered.AddListener(OnGrab);
    }

    private void OnGrab(SelectEnterEventArgs args) // Called when the object is grabbed
    {
        // If already grabbed once, do nothing
        if (hasGrabbedOnce) return;

        Debug.Log("The correct button was pressed."); // Debug

        hasGrabbedOnce = true; // Set flag
        source.PlayOneShot(clip, 1f); // Play audio clip        
    }
}

