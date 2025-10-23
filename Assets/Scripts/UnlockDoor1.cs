using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class UnlockDoor1 : MonoBehaviour
{
    // Game obj variables
    public GameObject doorHandle;
    public GameObject door;
    public GameObject key;

    // Time delay variables
    private float time1 = 2f; 
    private float time2 = 3f; 

    // Audio variables
    public AudioSource source;
    public AudioClip clip;


    // Called when another collider enters this trigger collider
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == doorHandle) // Check if the collider belongs to the door handle
        {
            Debug.Log("Door1 is unlocked."); // Debug
            gameObject.SetActive(false); // Disactivates key
            key.SetActive(true); // Activates "key"
            Invoke("ClipPlay", time1); // Calls ClipPlay method
            Invoke("OpenDoor", time2);     // Calls Disactivate method
        }
        
    }
    void ClipPlay()
    {
        source.PlayOneShot(clip, 1f);    // Play audio clip
    }

    void OpenDoor() // Opens door visually
    {
        // Transform position
        door.transform.localPosition  = new Vector3(17.3f, -7.995f, -17.8f);

        // Transform rotation
        door.transform.localRotation  = Quaternion.Euler(0, 100f, 0); 
    }
}
