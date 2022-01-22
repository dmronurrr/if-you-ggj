using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class VideoScripts : MonoBehaviour
{
    public VideoPlayer vid;
    public Animator anim;
    public LevelController levelController;
    void Start()
    {
        vid.loopPointReached += CheckOver;
        vid.SetDirectAudioVolume(0,0.3f);

    }
 
    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        anim.Play("CloseEyes");
    }
}
