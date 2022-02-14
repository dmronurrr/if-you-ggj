using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingCalculate : MonoBehaviour
{
    MakeChoices makeChoices;
    public int effectToEnding;
    public int ending;
    private void Start() 
    {
        effectToEnding=PlayerPrefs.GetInt("Ending");
    }
    
    public void EditEnding()
    {
        makeChoices=GameObject.FindGameObjectWithTag("Choice").GetComponent<MakeChoices>();
        effectToEnding+=makeChoices.effectToEnding;
        SetEnding();
    }
    public void SetEnding()
    {
        PlayerPrefs.SetInt("Ending",effectToEnding);
        GetEnding();
    }
    public void GetEnding()
    {
        ending=PlayerPrefs.GetInt("Ending");
    }
}
