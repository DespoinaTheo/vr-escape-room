using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2Shut : MonoBehaviour
{
    // Game obj variables
    public GameObject XrOrigin;
    public GameObject door2;
    
    private float time = 2f; // Time delay variable

    // Audio variables
    public AudioSource source;

    public AudioClip clip;

    // Called when another collider enters this trigger collider
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == XrOrigin) // Check if the collider belongs to the XR Origin
        {
            gameObject.SetActive(false); // Tel Anchor gets disactivated as it is useless now
            Debug.Log("Door2 is now closed"); // Debug
            Invoke("ShutDoor", time); // Calls Activate method
        }
    }

    void ShutDoor()
    // Closes visualy Door2, plays audio clip
    {
        // Transform position
        door2.transform.localPosition  = new Vector3(4.39f, -2.445f, -15.95f);

        // Transform rotation
        door2.transform.localRotation  = Quaternion.Euler(0, 0, 0);
        source.PlayOneShot(clip, 1f);
    }
}
