using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    public SelectionManager selectionManager;
    public Pause pauseManager;
    public AudioSource audioSource,headSource;
    public float timer=3;
    public bool isStop;
    
    private void Update()
    {
        if(isStop)
        {
            timer-=1*Time.deltaTime;
        }
        if(timer<=0)
        {
            headSource.Stop();
        }
        if(pauseManager.isPaused)
        {
            audioSource.Pause();
        }
        else if(!pauseManager.isPaused&&selectionManager.isPlay)
        {
            if(!audioSource.isPlaying)
            {
                audioSource.Play();
                isStop=true;
                
            }
            
        }
    }
}
