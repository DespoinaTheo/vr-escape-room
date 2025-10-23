using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnlockDoor2 : MonoBehaviour
{
    // Game obj variables
    public GameObject doorHandle;
    public GameObject key;
    public GameObject door2;

    // Time delay variables
    private float time = 2.5f;
    private float time2 = 5f;

    // Audio variables
    public AudioSource source;

    public AudioClip clip;

    // Reference for Timer
    public Timer timerScript;

    // Called when another collider enters this trigger collider
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == doorHandle) // Check if the collider belongs to the door handle
        {
            Debug.Log("Door2 has opened."); // Debug

            gameObject.SetActive(false); // Deactivates key
            key.SetActive(true); // Acitvates "key"

            source.PlayOneShot(clip, 1f); // Play audio clip

            // Schedule each event with a delay
            Invoke("Actions1", time);
            Invoke("Exit", time2);

            // Stops timer and saves final time
            if (timerScript != null)
            {
                timerScript.StopTimer();
                float finalTime = timerScript.GetFinalTime();
                PlayerPrefs.SetFloat("FinalTime", finalTime);
                PlayerPrefs.Save();

                Debug.Log("Final time: " + finalTime);
            }
        }
    }

    void Actions1()
    {        
        source.Stop(); // Background music stops 

        // Opens Door2
        door2.transform.localPosition  = new Vector3(2.95f, -2.445f, -17.97f); // Transform position
        door2.transform.localRotation  = Quaternion.Euler(0, -100f, 0); // Transform rotation
    }

    void Exit()
    {
        SceneManager.LoadScene("ExitScene"); // Loads the exit scene
    }
}
