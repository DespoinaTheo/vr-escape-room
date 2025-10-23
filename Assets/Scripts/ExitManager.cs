using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ExitManager : MonoBehaviour
{
    // UI (text and sound) variable
    public TMPro.TMP_Text Message2;
    public TMPro.TMP_Text finalTimeText;

    // time delay variables
    private float time1 = 1f;
    private float time2 = 5f;
    private float time3 = 10f;
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("You Escaped."); // Debug

        // for the timer UI element
        float finalTime = PlayerPrefs.GetFloat("FinalTime", 0f); // Calls Finaltime from PlayerPrefs
        int minutes = Mathf.FloorToInt(finalTime / 60);
        int seconds = Mathf.FloorToInt(finalTime % 60);
        finalTimeText.text = string.Format("Final Time: {0:00}:{1:00}", minutes, seconds);

        // Schedule each event with a delay
        Invoke("txt1Activated", time1);
        Invoke("txt2Activated", time2);
        Invoke("LoadScene", time3);
    }

    void txt1Activated() // Activates the FinalTime UI element
    {
        finalTimeText.gameObject.SetActive(true);
    }

    void txt2Activated() // Activates the Message2 UI element
    {
        Message2.gameObject.SetActive(true);
    }

    void LoadScene() // Loads the intro scene
    {
        Debug.Log("Intro Scene is loaded."); // Debug
        SceneManager.LoadScene("IntroScene");
    }
}
