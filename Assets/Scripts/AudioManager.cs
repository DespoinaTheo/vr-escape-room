using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Audio variables
    public AudioSource source;

    public AudioClip clip1;
    private float time = 1f; // Time delay variable
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Started."); // Debug
        Invoke("StartSound", time); // Calls StartSound method
    }

    void StartSound() // Play Audio clip 
    {
        source.PlayOneShot(clip1, 1f);
    }
}
