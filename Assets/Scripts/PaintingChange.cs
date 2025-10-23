using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingChange : MonoBehaviour
{
    // Game obj variables
    public GameObject rightController;
    public GameObject leftController;

    // Audio variables
    public AudioSource source;

    public AudioClip clip;
    private bool done = false; // Bool variable (flag)

    void OnTriggerEnter(Collider other) //Called when another collider enters this trigger collider
    {
        if (!done) // Code runs only once
        {
            if (other.gameObject == rightController || other.gameObject == leftController)
            // Check if the collider belongs to either of the controllers
            {
                Debug.Log("New painting is revealed"); // Debug
                source.PlayOneShot(clip, 1f); // Play audio clip
                done = true; // Set flag
            }
        }
    }
}
