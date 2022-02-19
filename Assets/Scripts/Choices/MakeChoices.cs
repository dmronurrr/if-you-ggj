using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MakeChoices : MonoBehaviour
{
    public string currentChoice;
    public int effectToEnding;
    public List<string> choices=new List<string>();
    public List<string> effects=new List<string>();
    public Text text;
    public TextMeshProUGUI messages;
    public GameObject otherChoices;
    public int choiceNumber;
    EndingCalculate endingCalculate;
    private void Start() 
    {
        this.gameObject.SetActive(false);
        text.text=currentChoice;
        endingCalculate=GameObject.Find("EndingCalculate").GetComponent<EndingCalculate>();
    }
    public void Deactive()
    {
        this.gameObject.SetActive(false);
    }
    public void Active()
    {
        this.gameObject.SetActive(true);
    }
    public void ChangeTheText()
    {
        otherChoices.SetActive(false);
        messages.text="";
        for(int i=choiceNumber;i<choices.Count;i++)
        {  
            if(i<choices.Count)
            {
                text.text=choices[i];
                currentChoice=choices[i];
                choiceNumber+=1;
                break;
            }
        }
        for(int i=choiceNumber-1;i<effects.Count;i++)
        {
            messages.text="";
            if(i<effects.Count)
            {
                messages.text=effects[i];
                break;
            }
        }
        
    }
    private void Update() 
    {
        if(choiceNumber==choices.Count)
        {
            endingCalculate.EditEnding();
            Destroy(gameObject);
        }
    }
}
