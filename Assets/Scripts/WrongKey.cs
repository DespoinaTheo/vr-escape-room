using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongKey : MonoBehaviour
{
    public GameObject doorHandle; // Game obj variable

    // Audio variabled
    public AudioSource source;

    public AudioClip clip;

    // Called when another collider enters this trigger collider
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == doorHandle) // Check if the collider belongs to the door handle
        {
            Debug.Log("Wrong Key."); // Debug
            source.PlayOneShot(clip, 1f); // Play the audio clip
        }
    }
}
