using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messenger : MonoBehaviour
{
    public Renderer render;
    public string mesage;
    public Text text;
    public GameObject image;
    private void Start() {
    render=GetComponent<Renderer>();
    }
    public void OpenMessenger()
    {
        text.text=mesage;
        image.SetActive(true); 
        render.enabled=true;
    }
    public void CloseMessenger()
    {
        image.SetActive(false);
        render.enabled=false;
    }   
}
