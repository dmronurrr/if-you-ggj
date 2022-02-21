using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare : MonoBehaviour
{
    public bool isVoice,isObject;
    AudioSource audioSource;
    public float wait;
    public Transform target;
    private void Start() 
    {
        audioSource=GameObject.Find("JSVoice").GetComponent<AudioSource>();
    }
    public void Triggered()
    {
        if(isVoice)
        {
            JSWithVoice();
        }
        if(isObject)
        {
            JSWithObjects();
        }
    }
    public void JSWithVoice()
    {
        if(!audioSource.isPlaying)
        {
            audioSource.Play();
            Debug.Log("Hocam");
        }
    }
    public void JSWithObjects()
    {
        this.gameObject.transform.position=target.position;
        StartCoroutine(nameof(DestroyObject));
    }
    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(wait);
        Destroy(this.gameObject);
    }
}
