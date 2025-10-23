using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class IntroManager : MonoBehaviour
{
    // UI (text and sound) variables
    public TMPro.TMP_Text Subtittle;
    public TMPro.TMP_Text Name;
    public AudioSource source;

    public AudioClip clip;
    
    // time delay variables
    private float time1 = 1f;
    private float time2 = 41.5f;
    private float time3 = 47f;
    private float time4 = 48f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Started."); // Debug

        // Schedule each event with a delay
        Invoke("IntroSound", time1);
        Invoke("SubActivated", time2);
        Invoke("NameActivated", time3);
        Invoke("LoadScene", time4);
    }

    void IntroSound() // Plays the intro audio clip
    {
        source.PlayOneShot(clip, 1f);
    }
    void SubActivated() // Activates the subtitle UI element
    {
        Subtittle.gameObject.SetActive(true);
    }
    void NameActivated() // Activates the name UI element
    {
        Name.gameObject.SetActive(true);
    }
    void LoadScene() // Loads the main scene
    {
        Debug.Log("Main Scene is loaded."); // Debug
        SceneManager.LoadScene("MainVRScene");
    }
   
}
