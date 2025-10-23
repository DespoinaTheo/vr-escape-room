using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText; // UI variable
    private float timeElapsed; // Total elapsed time variable
    private bool timerActive = true; // Controls if the timer is activated

    // Update is called once per frame
    void Update()
    {
        if (!timerActive) return; // Skips if timer is not activated

        timeElapsed += Time.deltaTime; // Adds extra time per frame
        int minutes = Mathf.FloorToInt(timeElapsed / 60); // For whole minutes
        int seconds = Mathf.FloorToInt(timeElapsed % 60); // For remaining secs
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds); // Displays time in MM:SS format
    }

    public void StopTimer()
    {
        timerActive = false; // Stops the timer from updating
    }

    public float GetFinalTime() 
    {
        return timeElapsed; // Returns the total time elapsed
    }
}
