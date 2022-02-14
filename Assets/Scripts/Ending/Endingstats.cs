using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endingstats : MonoBehaviour
{
    private void Update() 
    {
        
    }
    public void SetEnding(int integer)
    {
        PlayerPrefs.SetInt("Ending",integer);
    }
    public void GetEnding()
    {
        PlayerPrefs.GetInt("Ending");
    }
}
