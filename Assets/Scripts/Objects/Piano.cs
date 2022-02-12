using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Piano : MonoBehaviour
{
    AudioSource audioSource;
    LevelController levelController;
    private void Start() 
    {
        audioSource=GetComponent<AudioSource>();  
        levelController=GameObject.Find("EventSystem").GetComponent<LevelController>(); 
    }
    public void PlayPiano()
    {
            if(!audioSource.isPlaying)
            audioSource.Play(); 
            levelController.StartCoroutine(nameof(levelController.NextLevel)); 
    } 
}