using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class Options : MonoBehaviour
{
    public AudioMixer audioMixer;
    public float vol;
    public void SetVolume(float volume)
    {
        vol=volume;
        PlayerPrefs.SetFloat("Vol",vol);
        audioMixer.SetFloat("Volume",volume);
    }
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    public void setFullScreen(bool isFullscreen)
    {
        Screen.fullScreen=isFullscreen;
    }
    public void SetSensitivity(float sens)
    {       
        PlayerPrefs.SetFloat("sens",sens);
    }
}
