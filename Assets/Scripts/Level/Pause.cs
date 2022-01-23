using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool isPaused=false;
    public GameObject canvas;
    public AudioSource audioSource;
    public float voice;
    private void Start() 
    {
        
        Time.timeScale=1;
        isPaused=false;
    }
    public void Update()
    {
        voice = PlayerPrefs.GetFloat("Vol");
        audioSource.volume=voice;
        if(!isPaused)
        StopGame();
        else
        StartGame();
    }
    public void StartGame()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            audioSource.Play();
            Cursor.lockState=CursorLockMode.Locked;
            Time.timeScale=1;
            isPaused=false;
            canvas.SetActive(false);
        }
    }
    public void StopGame()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            audioSource.Pause();
            Cursor.lockState=CursorLockMode.None;
            Time.timeScale=0;
            isPaused=true;
             canvas.SetActive(true);
        }
    }
    public void StartGameWithButton()
    {
        audioSource.Play();
        Cursor.lockState=CursorLockMode.Locked;
        Time.timeScale=1;
        isPaused=false;
        canvas.SetActive(false);
    }
}
