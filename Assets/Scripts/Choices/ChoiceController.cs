using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceController : MonoBehaviour
{
    public Animator animator;
    public Animation[] animations;
    public int animationNumber;
    public MakeChoices [] makeChoices;
    private void Start() 
    {
        animations=GetComponents<Animation>();
    }
    public void PlayAnimations()
    {
        for(int i=animationNumber;i<animations.Length;i++)
        {  
            if(i<animations.Length)
            {
                animations[i].Play();
                makeChoices[i].Deactive();
                break;
                
            }      
        }
    }
}
