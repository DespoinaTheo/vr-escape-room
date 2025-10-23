using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonChecker : MonoBehaviour
{
    // Game obj variables
    public GameObject button1;
    public GameObject button2;
    public GameObject key;
    public Material newButtonMat; // Material variable
    private bool actionDone = false; // Bool variable (flag)
    private float time = 2f; // Time delay variable

    // Audio variables
    public AudioSource source;

    public AudioClip clip1;

    void Update()
    {
        // Renderer components of both buttons
        Renderer r1 = button1.GetComponent<Renderer>();
        Renderer r2 = button2.GetComponent<Renderer>();

        if (!actionDone) // Code runs only once
        {     
            // Check that both buttons exist and both have the new material applied       
            if (r1 != null && r2 != null &&
            r1.sharedMaterial == newButtonMat &&
            r2.sharedMaterial == newButtonMat)
            {
                Debug.Log("Key7 is revealed."); // Debug
                key.SetActive(true); // Key obj activated on scene
                Invoke("ClipCaller", time); // Calls ClipCaller method
                actionDone = true; // Set flag
            }
        }
    }

    void ClipCaller() // Play audio clip
    {
            source.PlayOneShot(clip1, 1f);
    }
    
}
