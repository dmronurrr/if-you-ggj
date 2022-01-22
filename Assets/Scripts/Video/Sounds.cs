using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Sounds : MonoBehaviour
{
    public float volume;
    public AudioMixer audioMixer;
    void Update()
    {
        volume=PlayerPrefs.GetFloat("Vol");
        audioMixer.SetFloat("Volume",volume);
    }
}
