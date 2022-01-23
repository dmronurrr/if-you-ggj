using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piano : MonoBehaviour
{
    AudioSource audioSource;
    public SelectionManager selectionManager;

    private void Start() {
        audioSource=GetComponent<AudioSource>();
    }
    private void Update() 
    {
        if(selectionManager.piano)
        {
            if(!audioSource.isPlaying)
            audioSource.Play();
        }
    }
}
